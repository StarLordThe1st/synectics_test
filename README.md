# **synectics_test**

A client in the retail sector provides several files tracking all their sales. Each file contains up to a million lines of the following format:

                                                             31/03/2021##245.39

Each line consists of the date of sale, a delimiter (##), and the sale amount. Note that multiple sales can exist for the same date. The format of the date and the amount shall be configurable by the user.

Every now and then, the client needs to generate some statistics on their data. Supported statistics:
* Average of earnings for a range of years.
* Standard deviation of earnings within a specific year.
* Standard deviation of earnings for a range of years.

Using Java, C#, or C++, write a console application demonstrating your design and coding skills, and help the client perform the required calculations.

Submit your solution’s source code, a screenshot of a sample run of the application and a set of brief instructions to the client on how to use your application.

# **Instructions**
### Run application
* After
* Navigate to synectics_test\synectics_test\bin\Release\net9.0\win-x64 and run synectics_test.exe

### Usage
* Enter the path of the sales file as prompt by the console. File can directly be drag and dropped in the console window or manualy entered.
* Select one of the available operations by typing the operation number.
* Depending on the operation enter the start year and end year or the year of which you want the statistics to evaluate.
* Repeat by typing "y" or exit end application by pressing "n" when prompted.
