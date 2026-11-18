# Reminder Message Service

## Project Description

Reminder Message Service is a simple application developed using C# and .NET. It automatically writes predefined reminder messages to a log file at regular intervals of 5 minutes.

The application maintains a list of reminder messages and writes the next message whenever the timer interval is completed. After writing the last message, it automatically starts again from the first message.

This project demonstrates timer operations, message sequencing, automatic logging, and file handling in C#.

## Features

- Store multiple predefined reminder messages.
- Automatically write a message every 5 minutes.
- Display messages in a predefined sequence.
- Move to the next message after each interval.
- Restart the sequence after the last message.
- Save reminder messages in a log file.
- Include date and time with each log entry.
- Perform automatic logging without manual input.

## Technologies Used

- C#
- .NET
- Visual Studio
- System.IO Namespace
- System.Timers or System.Threading.Timer

## Main Functionalities

### 1. Reminder Messages
- Maintain a list of predefined messages.
- Read messages one by one.
- Write the next message after every 5 minutes.

### 2. Timer Operations
- Execute the reminder operation every 5 minutes.
- Automatically trigger the next message.
- Repeat the timer operation continuously.

### 3. Message Sequence
- Start from the first message.
- Move to the next message after each timer interval.
- Return to the first message after the last message.

### 4. Log File Management
- Save reminder messages in a text file.
- Record the date and time of each message.
- Append new messages without deleting previous entries.





## Author

**Vishnu Kumar**
**output screen**
![Uploading image.png…]()

## License

This project is created for educational and learning purposes.
