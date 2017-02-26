## Mr Fix-It

### By: Daniel Munger
### Description

_{# A repair technician job service. User may post jobs to site, and create worker accounts to claim jobs.}_

###COMPLETED USER STORIES:
* Users can register and log on
* Users may sign up to be "workers" on the site.
* New jobs may be added to the jobs list.
* A job can be assigned to a worker.
* A worker may take on mulitple jobs from the Worker Dashboard.
* Make *claiming* a job an **AJAX** action.
* A worker may designate one **active** job at a time. **AJAX**
* Workers may mark jobs complete, and select a new active job. **AJAX**

### Setup/Installation Requirements

  * _Clone this program from my GitHub: https://github.com/DanielMunger/MrFixIt-dotnet
  * _Navigate into cloned project folder
  *
  * Database creation Instructions: (see below)
  * _Using local server_
  * _Replace 'DESKTOP-GC3DC7B\\SQLEXPRESS' with local server name in GummiBearKingdomContext.cs as well as appsettings.json file._
  * _Navigate to /src/MrFixIt
  * _Open local server management tool and connect to server.
  * _Then type in Powershell, 'dotnet ef database update'
  * _Verify database creation.
  * _In Visual Studio launch IIS Express. 
  * _Follow website instructions_

### Known Bugs

_{Routes to 'Job/Index' and 'Home/Index' do not work for users that are not workers/not logged in.}_

### Technologies Used

_{Written using Visual Studio in C# on the ASP.Net Core Framework, complied with MicroSoft PowerShell, uses Microsoft SQl Server Management Studio and Jquery}_

### License

*{ This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.}*

Copyright (c) 2017 **_{Daniel Munger}_*