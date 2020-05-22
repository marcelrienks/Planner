# Planner
V1.8.9
02-08-2007

**Note: this was written back in 2007, and has not been look at again
since.**

# INTRODUCTION 
A day planner, allowing you to keep a time sheet of jobs done during
the day (aimed at helping programmers), keep track of tasks that
need to be done, and keep general notes.

The planner can be minized to the System tray for easy access.

TimeSheet:
This allows you to easily add a new Timesheet item everytime you
start work on a new job, allowing you to keep track of all tasks
done during the day. It also allows you to specify pre determined
Categories for your jobs. You can link a specific TimeSheet job to a
Todo task, allowing you to action Todo tasks, and gives you the
option of automatically marking the task complete when the Timesheet
items end time is set. TimeSheet also calculates specific time taken
to complete a job, and totals the time for one or more specified
days.

Todo:
This allows you to keep track of tasks that need to be done,
with start and end dates, as well as a completed flag. Any open
Todo tasks can be linked to a TimeSheet item.

Notes:
This allows you to make simple notes, and stores them with a
datetime.

All data input into the Planner is Serialized into an xml file
is stored with the exe. Everytime the xml file is updated a backup
is made of the existing xml file. This allows the user to restore
the backup if the current xml file becomes corrupted.

# NEW FEATURES AND FUNCTIONS IN THIS RELEASE
This release implements these new features and functionality:
* automatically marks linked Todo task complete when Timesheet items end time is set.
* Menu structure has changed allowing more options.

# GETTING STARTED
## SOFTWARE DEPENDENCIES
Windows operating system
Microsoft .Net Framework 2.0.50727
## INSTALLATION INSTRUCTIONS
Run setup.exe file.
This will install the Planner in the Default location
(C:\Program Files\Planner) and includes a shortcut places in the
users Program Menu, under Planner.

# SOURCE CODE INFORMATION
## MAIN CLASSES
* Componants:  
	* Categories.cs		(Categories object)  
	* Notes.cs		(Note object)  
	* Timesheet.cs		(TimeSheet object)  
	* ToDo.cs			(Todo Object)  
* Controls:  
	* CategoriesControl.cs	(logic behind TimeSheet Categories)  
	* NotesControl.cs		(logic behind Notes)  
	* TimeSheeetControl.cs	(logic behind TimeSheet jobs)  
	* TodoControl.cs		(logic behind Todo tasks)  
* Persistence:
	* Data.cs			(Data object which instantiates all Componants)  
	* Persist.cs		(logic behind persisting Data.cs)  
* Planner:  
	* Utilities.cs		(holds common functions)
