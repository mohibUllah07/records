

List<object> Allpersons = new List<object>()
{
new PERSON()
{
    name = "mohibullah",
    lastName = "khan",
    age = 20
},

new PERSON()
{
    name = "dsdfas",
    lastName = "khdsfgan",
    age = 20
},


new PERSON()
{
    name = "dsf",
    lastName = "s",
    age = 20
},


new PERSON()
{
    name = "uskhdfkls",
    lastName = "ksbjkf",
    age = 20
}


};

/*PERSON p2 = new()
{
    name = "azeen",
    lastName = "shazan",
    age = 29
};

PERSON p3 = new()
{
    name = "kami",
    lastName = "khan",
    age = 10
};

PERSON p4 = new()
{
    name = "kashif",
    lastName = "khan",
    age = 30
};*/
//Console.WriteLine(p1);

foreach (PERSON n in Allpersons)

{
    Console.WriteLine(n);
}


public record PERSON()
{
    public string name;
    public string lastName;
    public int age;
}
