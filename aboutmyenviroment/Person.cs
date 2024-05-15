using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace aboutmyenviroment;

public class Person
{
    public string Name { get; set; }
    public DateTime Birth { get; set; }
}


public class Meeting
{
    public static void RunMetting()
    {
       Person person1 = new();
        person1.Birth = new(1992, 13, 10);

        List<Person> people = new()
        {
            new(){Name = "Pedro", Birth = new(1922, 12,43) }
        };

    }
}