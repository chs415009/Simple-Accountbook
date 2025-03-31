# Simple-Accountbook

![C#](https://img.shields.io/badge/C%23-.NET-blue.svg)
![Platform](https://img.shields.io/badge/platform-Windows-brightgreen.svg)
![License](https://img.shields.io/badge/license-MIT-green.svg)

**Simple-Accountbook** is a comprehensive financial management application built with C# and .NET Framework. This desktop application provides a user-friendly interface to track expenses and income, categorize transactions, and manage your personal finances effectively.

## 🌟 Features

- **Secure User Authentication**: Personal account system with username and password protection
- **Intuitive Transaction Management**: Add, view, and delete financial records easily
- **Hierarchical Category System**: Organized expense and income categories
- **Date Selection**: Calendar interface for precise transaction dating
- **Advanced Filtering**: View transactions by category with hierarchical search
- **Data Persistence**: Automatic saving of transaction data between sessions
- **Input Validation**: Intelligent handling of transaction amounts based on category type

## 📥 Installation & Setup

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
The application starts with a secure login interface:

- **First-time users**: Enter your desired username and password to register
- **Returning users**: Enter your credentials to access your account
- **Validation**: The system checks for empty fields and correct password input

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
The transaction management form provides comprehensive viewing and management capabilities:

1. **Transaction List**: View all transactions with details including category, description, amount, and date
2. **Category Filtering**: Filter transactions by selecting categories from the hierarchical list
3. **Deletion**: Select and remove individual transactions as needed

![Transaction Management](./bin/4.png)

## 💡 Tips & Best Practices

- **Date Selection**: Always select from year to day sequentially to ensure proper date handling
- **Amount Entry**: 
  - For expenses: You can enter either positive or negative numbers (positive will be converted to negative)
  - For income: Always enter positive numbers
- **Transaction Deletion**: Can only be performed one record at a time
- **Exit Options**: 
  - Select "Yes" to save and exit
  - Select "No" to view all records before exiting without saving

## 🔧 Technical Implementation

- **Multi-form Architecture**: Structured application flow with dedicated forms for each function
- **User Authentication System**: Secure account management
- **Hierarchical Data Structures**: Efficient category organization
- **Transaction Validation**: Intelligent handling of financial data
- **UI/UX Design**: User-friendly interface with clear visual feedback

## 🛠️ Future Development Plans

- Data visualization and reporting
- Budget setting and tracking
- Export functionality to CSV/Excel
- Cloud synchronization
- Mobile companion application

## 📜 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 👨‍💻 About the Developer

Simple-Accountbook was developed to demonstrate proficiency in C# programming, Windows Forms application development, and software architecture design. The application showcases:

- Object-oriented programming expertise
- Database integration and management
- User interface design principles
- Multi-form application architecture
- Security implementation for user data

---

**Simple-Accountbook** - Managing your finances with elegance and efficiency.
