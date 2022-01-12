using DL;
using UI;

IRepo repo = new FileRepo();
RRBL bl = new RRBL(repo);
MainMenu menu = new MainMenu(bl);

menu.Start();
