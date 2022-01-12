using DL;
using UI;

IRepo repo = new FileRepo();
RRBL bl = new RRBL(repo);
MainMenu menu = new MainMenu(bl);
Log.Logger = new LoggerConfiguration()
.WriteTo.File(@"..\DL\logger.txt")
.CreateLogger();
menu.Start();
