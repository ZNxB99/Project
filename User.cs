class User{
    public string email;
    public int password;
    public string firstname;
    public string lastname;
    public string destination;
    public User(string email, int password, string firstname, string lastname, string destination){
        this.email = email;
        this.password = password;
        this.firstname = firstname;
        this.lastname = lastname;
        this.destination = destination;
    }
    public string Getemail(){
        return this.email;
    }
    public int GetPassword() {
        return this.password;
    }
    public string GetFirstName(){
        return this.firstname;
    }
    public string GetLastName(){
        return this.lastname;
    }
    public string GetDestination(){
        return this.destination;
    }
}