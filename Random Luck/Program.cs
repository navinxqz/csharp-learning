Random rand = new Random();
int luck = rand.Next(1, 101);

string[] txt = {"You have much to ","Today is the day to ", "Whatever work you do ", "This is an ideal time to "};
string[] good = {"look forward to.", "be creative.", "will be successful.", "make a change."};
string[] bad = {"be cautious.", "avoid conflict.", "be patient.", "be careful."};
string[] neutral = {"be productive.", "enjoy time with friends and family.", "be realistic.", "rethink your goals."};

Fortune();

void Fortune(){
    System.Console.WriteLine("Your luck for today is: ");
    string[] fortune = (luck > 70) ? good : (luck < 30) ? bad : neutral;

    for(int i = 0; i < 4; i++){
        System.Console.WriteLine(txt[i] + fortune[i]);
    }
}