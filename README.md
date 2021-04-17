# LogWrappers
A common interface for a Console logger and Serilog so objects that are shared between the front end and back end can use the IMessageLogger interface and have the appropriate logger injected in.  This is preferable over the built in Microsoft ILogger interface because you can enhance or swap out the logger as needed.
