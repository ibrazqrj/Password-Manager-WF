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

## 📸 Screenshots

### **🔑 Master Password Registration**
![image](https://github.com/user-attachments/assets/5dbae174-7280-48ca-b0c0-9691f0432e85)

### **🔐 Login**
![image](https://github.com/user-attachments/assets/21b6efdd-d9e4-400a-baab-878a58a3b401)

### **🏠 Home**
![image](https://github.com/user-attachments/assets/ef1723bc-2099-4ca8-a9e4-71c9086a8fea)

### **📋 All Items**
![image](https://github.com/user-attachments/assets/26ded667-44f4-48d3-92a9-1d6cbfbdb233)

### **➕ Add New Item**
![image](https://github.com/user-attachments/assets/a8dc9705-380f-4ed6-ab64-1de2ff9a3515)

### **🗑️ Delete Item**
![image](https://github.com/user-attachments/assets/0ee47a92-c00e-4048-8351-2cd631f0ceed)

### **🔀 Generate Random Password**
![image](https://github.com/user-attachments/assets/0f24308a-5196-4efb-a974-9837a4515e83)

### **🔄 Change Master Password**
![image](https://github.com/user-attachments/assets/3341f921-2648-48ba-8642-66492b734954)

## 🛠 Installation: Option 1
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

## 🛠 Installation: Option 2
### Steps to Run
1. **📥 Download the ZIP-File in the publish folder**
2. **▶️ Unzip & Run the installer**

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

## 🤝 Contributing
Feel free to contribute! If you find a bug or have a feature request:
1. Fork the repository 🍴
2. Create a new branch (`feature-new-feature`)
3. Commit changes and push 🚀
4. Submit a pull request 📩

---

## 📧 Contact
For any inquiries or suggestions, contact me via GitHub or open an issue in the repository.

