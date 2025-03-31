# Simple-Accountbook

![C#](https://img.shields.io/badge/C%23-.NET-blue.svg)
![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms-purple.svg)
![Project](https://img.shields.io/badge/Project-Academic-green.svg)

**Simple-Accountbook** is a desktop financial management application developed as an academic project using C# and .NET Windows Forms. This project demonstrates GUI development, multi-form architecture, and basic database operations in a Windows environment.

## 🌟 Features

- **User Authentication**: Login system with basic account creation
- **Multi-form Application**: Demonstrates navigation between different interfaces
- **Transaction Management**: Add, view, and delete financial records
- **Category System**: Organized expense and income categories
- **Date Selection**: Calendar interface for transaction dating
- **Search Functionality**: View transactions by category
- **Input Validation**: Form validation with user feedback

## 📥 Project Setup

### Prerequisites
- Windows operating system
- Visual Studio (2017 or later recommended)
- .NET Framework 4.5+

### Installation Steps
1. Clone the repository:
   ```
   git clone https://github.com/chs415009/simple-accountbook.git
   ```
2. Open the solution file in Visual Studio:
   ```
   AccoutingAPP.sln
   ```
3. Build and run the application directly from Visual Studio

## 🚀 Application Workflow

### User Authentication (Form 1)
The application starts with a login interface:

- **First-time users**: Enter desired username and password to register
- **Returning users**: Enter credentials to access your account
- **Validation**: System checks for empty fields and correct password input

![Authentication Interface](./bin/1.png)

### Main Dashboard (Form 2)
After successful authentication, you'll access the main dashboard with three primary functions:

- **離開 (Exit)**: Save and close the application
- **新增 (Add)**: Navigate to the transaction entry form
- **檢視 (View)**: Navigate to the transaction viewing and management form

![Main Dashboard](./bin/2.png)

### Transaction Entry (Form 3)
The transaction entry form allows you to add new financial records:

1. **Date Selection**: Choose year, month, and day sequentially for accurate dating
2. **Category Selection**: Choose from hierarchical categories for expenses or income
3. **Description**: Add details about your transaction
4. **Amount**: Enter the transaction amount
   - For expenses: Positive numbers are automatically converted to negative
   - For income: Must be entered as positive numbers

![Transaction Entry](./bin/3.png)

### Transaction Management (Form 4)
The transaction management form provides viewing and management capabilities:

1. **Transaction List**: View all transactions with details
2. **Category Filtering**: Filter transactions by selecting categories
3. **Deletion**: Select and remove individual transactions

![Transaction Management](./bin/4.png)

## 💡 Tips & Best Practices

- **Date Selection**: Always select from year to day sequentially to ensure proper date handling
- **Amount Entry**: 
  - For expenses: You can enter either positive or negative numbers
  - For income: Always enter positive numbers
- **Transaction Deletion**: Can only be performed one record at a time
- **Exit Options**: 
  - Select "Yes" to save and exit
  - Select "No" to view all records before exiting without saving

## 🔧 Technical Implementation

- **Windows Forms**: Uses .NET Windows Forms for GUI development
- **Object-Oriented Design**: Demonstrates class structure and inheritance
- **Event-Driven Programming**: Shows handling of user interactions
- **Basic Data Persistence**: Implements file operations for storing user data

## 🎓 Learning Outcomes

This academic project demonstrates proficiency in:

- C# programming fundamentals
- Windows Forms application development
- Multi-form application architecture
- User authentication implementation
- Form validation techniques
- Event handling in graphical user interfaces

## 📚 Academic Context

This project was developed as part of a C# Programming and GUI Development course. The assignment focused on creating a complete Windows application with multiple interconnected forms and data persistence capabilities.

## 🔄 Potential Extensions

- Data visualization for financial analysis
- Enhanced reporting functionality
- Data export capabilities
- Improved UI design and user experience

---

**Simple-Accountbook** - A C# Windows Forms academic project demonstrating desktop application development principles.
