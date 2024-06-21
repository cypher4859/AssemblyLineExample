// See https://aka.ms/new-console-template for more information

//"Hello, World!"


TheFactory BuildTheFactory() {
    TheFactory ourNewFactory = new TheFactory();
    return ourNewFactory;
}

TheFactory newFactory = BuildTheFactory();
newFactory.StartAssemblyLine();

class TheFactory {
    void SaysMessageToUser (string msg, int numberOfMessages) {
        Console.WriteLine(msg);
        Console.WriteLine(numberOfMessages.ToString());
    }

    string GetMessage () {
        string messageToUser = "Hello, World";
        return messageToUser;
    }

    void SupervisorGivesOrders () {
        string theMessage = GetMessage();
        SaysMessageToUser(theMessage, 1);
    }

    public void StartAssemblyLine() {
        Console.WriteLine("Workers!!!! Line up on the Wall!");
        Console.WriteLine("Assembly Line Starts");
        SupervisorGivesOrders();
    }
}
