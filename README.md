# 🔐 Password Manager (WinForms)

## Overview
This is a **Password Manager** application built using **C# WinForms**. The project aims to provide a secure and user-friendly interface for storing and managing passwords locally. It follows a structured **separation of logic and UI**, ensuring scalability and maintainability.

## ✨ Features
- **🔑 Master Password Authentication**
  - Secure authentication using a **hashed Master Password** (SHA-256)
- **🔒 Password Storage**
  - Store, edit, and delete saved passwords locally
- **🔐 Data Encryption**
  - Passwords are securely **AES-encrypted** before being stored
- **🖥️ User Interface (WinForms)**
  - Simple and intuitive UI for managing credentials

## 🛠 Installation
### Prerequisites
- **.NET 6.0+** (Ensure you have the latest .NET runtime installed)
- **Visual Studio 2022+** (Recommended for development and debugging)

### Steps to Run
1. **📥 Clone the Repository**
   ```sh
   git clone https://github.com/ibrazqrj/Password-Manager-WF.git
   cd Password-Manager-WF
   ```
2. **🛠 Open in Visual Studio**
   - Open the `Password-Manager-WF.sln` file in **Visual Studio**
3. **▶️ Build & Run**
   - Select `Debug` or `Release` mode
   - Click **Start** (or press `F5`)

## 🚀 Usage
1. **Set Up a Master Password**
   - Enter a strong password that will be **hashed (SHA-256)** and stored locally
   - This password will be used for authentication in future sessions
2. **Login with the Master Password**
   - Use the saved **hashed password** to access stored credentials
3. **Manage Your Passwords**
   - Add, view, edit, or delete stored credentials

## 🏗 Technologies Used
- **C# WinForms** - UI implementation
- **.NET Core** - Backend logic
- **AES Encryption** - Secure password encryption
- **SHA-256 Hashing** - Master password storage

## 🔮 Future Enhancements
- Implement **Two-Factor Authentication (2FA) 📲**
- Introduce **Cloud Syncing for Multi-Device Access ☁️**
- Improve **Password Generation Features 🛡️**

## 🤝 Contributing
Feel free to contribute! If you find a bug or have a feature request:
1. Fork the repository 🍴
2. Create a new branch (`feature-new-feature`)
3. Commit changes and push 🚀
4. Submit a pull request 📩

## 📧 Contact
For any inquiries or suggestions, contact me via GitHub or open an issue in the repository.

