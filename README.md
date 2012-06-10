# Core View
A complete Windows Diagnostic Utility for professionals

### What is Core View?
Core View is a complete computer diagnostic utility designed for professionals. It can read and display useful data about the system it runs on without requiring additional administrative rights or tools.

Core View displays hardware information, software information, drivers, address maps, conflicts, processes and even event logs along with real-time graphs and SMART-powered hard disk data.

It can also store any gathered information into a database, known as the Heuristic Database, so it is able to precisely compare the computer it is running on to previous machines at the press of a button – unveiling a completely new way of aiding the diagnosis of computer faults.

### Requirements
Core View has been designed to run with as little requirements as possible, so it self-contains nearly all the files it needs to operate. The only requirements that Core View needs are:
* One of the following versions of Windows
    * Windows 2000
    * Windows XP
    * Windows Vista
    * Windows 7
* Microsoft .NET 2.0 (installed by default as of Windows XP SP2)
* The Windows Management Instrumentation Service (enabled by default on all mentioned operating systems)
* A storage location available for both reading and writing to store the program. This could be from a hard disk, USB thumb drive or even over network. As long as you can write to it, it will work. Recommended capacity: 500MB or more.

### First Use
Core View is a standalone program meaning it can be run by itself without any installation. Simply copy the CoreView.exe file to a writeable location and double-click it to run.

Core View will then proceed to unpack any additional files it needs. This includes 2 DLL libraries, a user-editable XML configuration file and finally, the Heuristic Database Heuristics.db file (after the splash screen has closed).

You will proceed to see a splash screen (if enabled in configuration) which will show the progress of information loading. The program will then show the main window, where information is either already processed or still being fetched.

### Using the Heuristic Database
The Heuristic Database section is the most significant part of the program. It’s accessed via the Database tab on the main form, and has display boxes similar to other ‘Software’ tabs.

The Heuristic Database stores information about the computer the application is running on for later reference. Once stored, they can be compared to other computers that the application runs on, and a numerical score is returned showing the likeness of each computer.

This score is calculated using weightings, which can be edited with the Options dialogue. The actual database file is ‘Heuristics.db’, which is written with SQLite.

To start comparing previous computers stored in the database, click ‘Start Search’. The current computer does not have to added to the database in order to do this.

After the search is complete, previous computers can be loaded into the program as if you were running the program on them. This is done by clicking ‘Load Selected Computer’. After you are finished, the same button can be pressed again to return the program to its normal state.

*For more information, see Resources/Manual.pdf, or press the F1 key during use.*