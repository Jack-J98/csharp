# CSHARP- PRN292

### Config

```xml
<connectionStrings>
    <add name="Database" connectionString="Data Source=DESKTOP-J1VHJ12;Initial Catalog=******;User ID=sa;Password=123456" providerName="System.Data.SqlClient" />
</connectionStrings>
```

### Show console

```c#
[System.Runtime.InteropServices.DllImport("kernel32.dll")]
private static extern bool AllocConsole();
public Form()
{
    AllocConsole();
    InitializeComponent();
}
```