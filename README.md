# Crimelytics
Interactive C# app for exploring and visualizing european crime statistics.

Crimelytics is a Windows Forms application developed in C#. The application can be used to analyze the recorded police data of crimes, based on the type of crime, country, and the year the record was recorded. The application is capable of filtering, searching, and utilizes an interactive grid interface for the manipulation of data.  

## Features ⚡  

- The ability to load crime statistics, and save crime statistics from/to CSV files.  
- The ability to filter crimes by:  
  - Crime type: Homicide, Theft, Harm or Sexual Assault  
  - Country  
  - Year range   
- The ability to search crimes by keyword.  
- All the data will be displayed in a DataGridView. The DataGridView will have appropriate columns populated with its relevant data.  
- There is a status bar that will show the number of records on display.  
- There is a toolbar that will allow the user to complete common tasks such as Open, Save, Refresh, Fullscreen.  

## Crime Types 🕵️  

- **Homicide**  
- **Theft**  
- **Harm or Sexual Assault**  

## Country Filter 🌍  
- Will only allow for the selection of a single country.    
- There is an **All Countries** option that will display data of every country.  

## CSV Data Structure 📄  

The CSV data file must follow this structure:  
```bash
dataflow,ESTAT:CRIM_GEN$DEFAULTVIEW(1.0),Crimes recorded by the police by offence category,A,Annual,NR,Number,CrimeCode,CrimeName,CountryCode,CountryName,Year,,Value,,,,,
```
- **CrimeCode** - A unique code identifying the crime type.

- **CrimeName** - Descriptive name of the crime.

- **CountryCode** - ISO or internal code of the country.

- **CountryName** - Full name of the country.

- **Year** - The year of the record.

- **Value** - Number of crimes recorded.

### An example of a line from a CSV
```bash
dataflow,ESTAT:CRIM_GEN$DEFAULTVIEW(1.0),Crimes recorded by the police by offence category,A,Annual,NR,Number,ICCS0101,Intentional homicide,BE,Belgium,2006,,223,,,,,
```


## Usage 🚀
1. **Open CSV File**  
   Use the toolbar or `File -> Open` to load a crime data csv file.
2. **Apply Filters**  
   - Select country or “All Countries”.  
   - Select the crime types that you would like to filter on.  
   - Set the year range for your filters.  
   - Click **Apply Filters** to return updated data grid based on your selections.  
3. **Reset Filters**  
   Click **Reset** to clear all filters and see the entire dataset.  
4. **Save Filtered Data**  
   Use the toolbar or `File -> Save` to save the currently filtered data.  
5. **Search**  
   Enter a keyword in the search box to filter the crime description dynamically.  
## Requirements 💻  
- Windows 10 or later.  
- .NET Framework 4.8 (or compatible).  
- Visual Studio 2019 or later if using source code.  
## Project Structure 📂  
Crimelytics/
│
├─ MainForm.cs # Main logic and event handling
├─ MainForm.Designer.cs # Designer file with UI layout
├─ Program.cs # Application entry point
├─ crim_gen$defaultview_linear_2_0.csv # Example dataset
└─ README.md # Project documentation

## Status ✅

- This component loads, filters, and visualizes police-reported crime statistics, without any problems.
- The value column, country filters, and crime types are being displayed accurately.

## License 📝

This project is licensed under the MIT License. For more information, you can view the `LICENSE`. 
