using Nomber_3;

try
{
    var carsList = new main
    {
        new Machines { number = "A795MK797", crashies = false },
        new Machines { number = "610NPV", crashies = false },
        new Machines { number = "55-98-22", crashies = true },
        new Machines { number = "HF3519", crashies = true },
        new Machines { number = "H001KP78", crashies = true }
    };

    foreach (Machines machines in carsList)
    {
        if (machines.number == null || machines.number.Length == 0)
        {
            throw new ArgumentNullException(nameof(machines.number));
        }
    };

    carsList.TakeCars();
}
catch (ArgumentNullException a){Console.WriteLine($"{a.Message}");}