using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CriminalStatisticsAnalyzer
{
    public partial class MainForm : Form
    {
        private string csvFileName = "crim_gen$defaultview_linear_2_0.csv";
        private DataTable dt;
        private BindingSource bindingSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
            ApplyTheme();
            LoadCsvData();
        }

        private void ApplyTheme()
        {
            this.BackColor = Color.Black;
            foreach (Control c in this.Controls)
                ApplyThemeRecursively(c);
        }

        private void ApplyThemeRecursively(Control c)
        {
            if (c is GroupBox || c is Panel)
            {
                c.BackColor = Color.Black;
                c.ForeColor = Color.DarkRed;
            }
            if (c is Button || c is CheckBox)
            {
                c.BackColor = Color.DarkRed;
                c.ForeColor = Color.White;
            }
            if (c is ComboBox || c is TextBox || c is DateTimePicker)
            {
                c.BackColor = Color.FromArgb(30, 30, 30);
                c.ForeColor = Color.DarkRed;
            }
            if (c is DataGridView dgv)
            {
                dgv.BackgroundColor = Color.White;
                dgv.DefaultCellStyle.BackColor = Color.White;
                dgv.DefaultCellStyle.ForeColor = Color.Black;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.EnableHeadersVisualStyles = false;
            }
            foreach (Control child in c.Controls)
                ApplyThemeRecursively(child);
        }

        private string[] ParseCsvLine(string line)
        {
            var fields = new List<string>();
            var sb = new StringBuilder();
            bool inQuotes = false;
            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (c == '"')
                {
                    if (inQuotes && i + 1 < line.Length && line[i + 1] == '"')
                    {
                        sb.Append('"');
                        i++;
                    }
                    else
                        inQuotes = !inQuotes;
                }
                else if (c == ',' && !inQuotes)
                {
                    fields.Add(sb.ToString());
                    sb.Clear();
                }
                else
                    sb.Append(c);
            }
            fields.Add(sb.ToString());
            return fields.ToArray();
        }

        private void LoadCsvData(string filePath = null)
        {
            try
            {
                if (filePath == null)
                    filePath = Path.Combine(Application.StartupPath, csvFileName);

                if (!File.Exists(filePath))
                {
                    MessageBox.Show($"CSV file not found: {filePath}");
                    return;
                }

                var lines = File.ReadAllLines(filePath);
                if (lines.Length < 1)
                {
                    MessageBox.Show("CSV file is empty.");
                    return;
                }

                var rawRows = new List<string[]>();
                for (int i = 1; i < lines.Length; i++)
                {
                    rawRows.Add(ParseCsvLine(lines[i]));
                }

                dt = new DataTable();
                dt.Columns.Add("CrimeLabel", typeof(string));
                dt.Columns.Add("CountryCode", typeof(string));
                dt.Columns.Add("CountryName", typeof(string));
                dt.Columns.Add("Year", typeof(int));
                dt.Columns.Add("Value", typeof(int));

                foreach (var row in rawRows)
                {
                    string crime = row.Length > 8 ? row[8].Trim() : "";
                    string code = row.Length > 9 ? row[9].Trim() : "";
                    string cname = row.Length > 10 ? row[10].Trim() : "";
                    int year = -1;
                    int.TryParse(row.Length > 11 ? row[11].Trim() : "", out year);
                    int value = -1;
                    int.TryParse(row.Length > 13 ? row[13].Trim() : "", out value);

                    var newRow = dt.NewRow();
                    newRow["CrimeLabel"] = string.IsNullOrEmpty(crime) ? DBNull.Value : (object)crime;
                    newRow["CountryCode"] = string.IsNullOrEmpty(code) ? DBNull.Value : (object)code;
                    newRow["CountryName"] = string.IsNullOrEmpty(cname) ? DBNull.Value : (object)cname;
                    newRow["Year"] = year >= 0 ? (object)year : DBNull.Value;
                    newRow["Value"] = value >= 0 ? (object)value : DBNull.Value;
                    dt.Rows.Add(newRow);
                }

                bindingSource.DataSource = dt;
                dataGridView1.DataSource = bindingSource;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                var countries = dt.AsEnumerable()
                                  .Select(r => r.Field<string>("CountryName"))
                                  .Where(n => !string.IsNullOrWhiteSpace(n))
                                  .Distinct()
                                  .OrderBy(n => n)
                                  .ToList();
                countries.Insert(0, "All Countries");
                countryCombo.DataSource = countries;

                var years = dt.AsEnumerable().Where(r => r.Field<int?>("Year") != null).Select(r => r.Field<int>("Year")).ToList();
                if (years.Any())
                {
                    int minY = years.Min();
                    int maxY = years.Max();
                    yearFrom.Value = new DateTime(minY, 1, 1);
                    yearTo.Value = new DateTime(maxY, 1, 1);
                }

                statusLabel.Text = $"Status: Ready Records: {dt.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading CSV: " + ex.Message);
            }
        }

        private void fileOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "CSV Files|*.csv|All Files|*.*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    LoadCsvData(ofd.FileName);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            fileOpenToolStripMenuItem_Click(sender, e);
        }

        private void btnApplyFilters_Click_1(object sender, EventArgs e)
        {
            var filtered = dt.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string s = txtSearch.Text.Trim().ToLower();
                filtered = filtered.Where(r =>
                    (r.Field<string>("CrimeLabel") ?? "").ToLower().Contains(s) ||
                    (r.Field<string>("CountryName") ?? "").ToLower().Contains(s));
            }

            if (countryCombo.SelectedItem != null && countryCombo.SelectedIndex > 0)
            {
                string selectedCountry = countryCombo.SelectedItem.ToString();
                filtered = filtered.Where(r => (r.Field<string>("CountryName") ?? "") == selectedCountry);
            }

            int fromY = yearFrom.Value.Year;
            int toY = yearTo.Value.Year;
            filtered = filtered.Where(r =>
            {
                int? yr = r.Field<int?>("Year");
                return yr != null && yr >= fromY && yr <= toY;
            });

            bool h = chkHomicide.Checked;
            bool t = chkTheft.Checked;
            bool c = chkHarmOrSexualAssault.Checked;
            if (h || t || c)
            {
                filtered = filtered.Where(r =>
                {
                    string label = (r.Field<string>("CrimeLabel") ?? "").ToLower();
                    bool matchH = h && label.Contains("intentional homicide");
                    bool matchT = t && (label.Contains("robbery") || label.Contains("burglary"));
                    bool matchC = c && (label.Contains("acts causing harm") || label.Contains("injurious") || label.Contains("acts against property"));
                    return matchH || matchT || matchC;
                });
            }

            var list = filtered.ToList();
            DataTable filteredDt;
            if (list.Any())
                filteredDt = list.CopyToDataTable();
            else
                filteredDt = dt.Clone();

            bindingSource.DataSource = filteredDt;
            dataGridView1.DataSource = bindingSource;
            statusLabel.Text = $"Status: Filtered Records: {filteredDt.Rows.Count}";
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            countryCombo.SelectedIndex = 0;
            var years = dt.AsEnumerable().Where(r => r.Field<int?>("Year") != null).Select(r => r.Field<int>("Year")).ToList();
            if (years.Any())
            {
                yearFrom.Value = new DateTime(years.Min(), 1, 1);
                yearTo.Value = new DateTime(years.Max(), 1, 1);
            }
            chkHomicide.Checked = false;
            chkTheft.Checked = false;
            chkHarmOrSexualAssault.Checked = false;
            bindingSource.DataSource = dt;
            dataGridView1.DataSource = bindingSource;
            statusLabel.Text = $"Status: Ready Records: {dt.Rows.Count}";
        }

        private void yearTo_ValueChanged(object sender, EventArgs e) { }
        private void groupBoxFilters_Enter(object sender, EventArgs e) { }
    }
}
