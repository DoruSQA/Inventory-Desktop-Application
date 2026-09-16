# Inventory Desktop App

![C#](https://img.shields.io/badge/C%23-.NET-blue?logo=csharp)
![.NET](https://img.shields.io/badge/.NET-6.0-purple?logo=dotnet)
![NUnit](https://img.shields.io/badge/NUnit-testing-green?logo=nunit)
![Appium](https://img.shields.io/badge/Appium-desktop%20automation-red?logo=appium)
![WinAppDriver](https://img.shields.io/badge/WinAppDriver-Windows%20UI-blue)


<p align="center">
  <img src="docs/images/inventory-desktop-app.png" alt="Inventory Desktop App" width="850" height="464">
</p>

## Purpose / Scope

Windows desktop inventory management application created for
manual and automated testing purposes.
Supports both manual testing and desktop UI automation using
**Appium and WinAppDriver**.

## Features

- User authentication
- Product management
- Customer management
- Inventory management
- Input validation
- SQLite database

## Download & Use

### Option 1 — Compiled Application

Download the latest Windows release from [GitHub Releases](../../releases/latest).

1. Download the latest `.7z` archive.
2. Extract the archive to a local folder.
3. Run `InventoryDesktopApp.exe`.
4. Log in using the test credentials below.

#### Test Credentials

| Role | Username | Password |
|------|----------|----------|
| Admin | `admin123` | `zxcvbnm123!` |


### Option 2 — Run from Source

Clone the repository:

```bash
git clone https://github.com/DoruSQA/InventoryDesktopApp.git
```
Open InventoryDesktopApp.sln in Visual Studio then build and run the InventoryDesktopApp project.


## 🎯 Future Improvements

- Password reset functionality
- User management and role-based access control
- Advanced product and customer search
- Inventory product filtering & sorting
