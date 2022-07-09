
int ip1_8, ip1_16, ip1_24, ip1_32, ip2_8, ip2_16, ip2_24, ip2_32,IpClass1, IpClass2;

Console.WriteLine("Write the first 8bits of the first address");
ip1_8 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{ip1_8}.");

Console.WriteLine("Write the second 8bits of the first address");
 ip1_16 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{ip1_8}.{ip1_16}.");

Console.WriteLine("Write the third 8bits of the first address");
 ip1_24 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{ip1_8}.{ip1_16}.{ip1_24}.");

Console.WriteLine("Write the fourth 8bits of the first address");
 ip1_32 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The first ip is: {ip1_8}.{ip1_16}.{ip1_24}.{ip1_32}");


Console.WriteLine("Write the first 8bits of the Second address");
ip2_8 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{ip2_8}.");

Console.WriteLine("Write the second 8bits of the Second address");
ip2_16 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{ip2_8}.{ip2_16}.");

Console.WriteLine("Write the third 8bits of the Second address");
ip2_24 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{ip2_8}.{ip2_16}.{ip2_24}.");

Console.WriteLine("Write the fourth 8bits of the second address");
ip2_32 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The second ip is: {ip2_8}.{ip2_16}.{ip2_24}.{ip2_32}");

IpClass1 = CheckClass(ip1_8);
IpClass2 = CheckClass(ip2_8);


if (IpClass1 == IpClass2)
{
    if ((IpClass1 == 1) && (ip1_8 == ip2_8))
    {
        Console.WriteLine("Both hosts belong in the same network with IP_address:");
        Console.WriteLine($"{ip1_8}.0.0.0 and broadcast_address: {ip1_8}.255.255.255 ");
        return;
    }
    if ((IpClass1 == 2) && (ip1_8 == ip2_8) && (ip1_16 == ip2_16))
    {
        Console.WriteLine("Both hosts belong in the same network with IP_address:");
        Console.WriteLine($"{ip1_8}.{ip1_16}.0.0 and broadcast_address: {ip1_8}.{ip1_16}.255.255 ");
        return;
    }
    if ((IpClass1 == 3) && (ip1_8 == ip2_8) && (ip1_16 == ip2_16) && (ip1_24 == ip2_24))
    {
        Console.WriteLine("Both hosts belong in the same network with IP_address:");
        Console.WriteLine($"{ip1_8}.{ip1_16}.{ip1_24}.0 and broadcast_address: {ip1_8}.{ip1_16}.{ip1_24}.255 ");
        return;
    }

    Console.WriteLine("Hosts belong in different networks.");
}


static int CheckClass(int ip8)
{
    if (ip8 < 126)
    {
        return 1;
    }
    if (ip8 > 128 && ip8 < 191)
    {
        return 2;
    }
    if (ip8 > 192 && ip8 < 223)
    {
        return 3;
    }
    if (ip8 > 224 && ip8 < 239)
    {
        return 4;
    }
    if (ip8 > 240 && ip8 < 254)
    {
        return 5;
    }
    return 0;
}



