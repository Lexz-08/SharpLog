## SharpLog
### Description
Allows for easily logging events. Simply give the event that occured as a string, then the name of whatever sent the event and you're done!

### How To Use
I used the current Date and Time(s) I had at the moment for these examples.
Now the `MessageBox.Show(LoggedEvent);` is me assuming you have the `System.Windows.Forms` namespace referenced.
#### (Date W/ Time)
```csharp
string LoggedEvent = Logger.LogEvent("Form1", "Opened");
MessageBox.Show(LoggedEvent);

// MessageBox Message: '[6/1/2021, 5:57:10] Form1: Opened'
```

#### (Date W/OUT Time)
```csharp
string LoggedEvent = Logger.LogEvent("Form1", "Opened", default, false);
MessageBox.Show(LoggedEvent);

// MessageBox Message: '[6/1/2021] Form1: Opened'
```

#### (Time W/OUT Date)
```csharp
string LoggedEvent = Logger.LogEvent("Form1", "Opened", false);
MessageBox.Show(LoggedEvent);

// MessageBox Message: '[5:57:10] Form1: Opened'
```

#### (No Date/Time)
```csharp
string LoggedEvent = Logger.LogEvent("Form1", "Opened", false, false);
MessageBox.Show(LoggedEvent);

// MessageBox Message: 'Form1: Opened'
```

### Download
[SharpLog.dll](https://github.com/Lexz-08/SharpLog/releases/download/sharplog/SharpLog.dll)
