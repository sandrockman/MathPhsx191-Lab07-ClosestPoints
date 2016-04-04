using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author Victor Haskins
 * class Program Receives information from the player to compute the closest
 * point on a line or on a plane, depending on choices made and information
 * given. Calls the Vector3D class, accompanying the code.
 */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Units are entered in meters.");
        Console.WriteLine("1: Closest Point on Line.");
        Console.WriteLine("2: Closest Point on Plane.");
        Console.Write("Please Enter Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                ClosestPointLine();
                break;
            case 2:
                ClosestPointPlane();
                break;
            default:
                Console.WriteLine("Option not found.");
                break;
        }
    }

    static void ClosestPointLine()
    {
        Vector3D Q = new Vector3D();
        Vector3D P = new Vector3D();
        Vector3D dVector = new Vector3D();

        double x, y, z;

        x = y = z = 0;
        Console.WriteLine("Enter coordinates for point to check against Line.");
        Console.Write("X Value: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y Value: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Z Value: ");
        z = Convert.ToDouble(Console.ReadLine());
        Q.SetRectGivenRect(x, y, z);

        x = y = z = 0;
        Console.WriteLine("\nEnter coordinates for point of the Line's start.");
        Console.Write("X Value: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y Value: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Z Value: ");
        z = Convert.ToDouble(Console.ReadLine());
        P.SetRectGivenRect(x, y, z);

        x = y = z = 0;
        Console.WriteLine("\nEnter coordinates for direction vector from the Line's Start.");
        Console.Write("X Value: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y Value: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Z Value: ");
        z = Convert.ToDouble(Console.ReadLine());
        dVector.SetRectGivenRect(x, y, z);

        Vector3D closestPoint = Q.ClosestPointOnLine(P, dVector);

        closestPoint.PrintRect();

        Vector3D mag = Q - closestPoint;
        Console.WriteLine("Distance from ship to asteroid: {0:F2} m.", mag.GetMagnitude());
    }

    static void ClosestPointPlane()
    {
        Vector3D Q = new Vector3D();
        Vector3D P1 = new Vector3D();
        Vector3D P2 = new Vector3D();
        Vector3D P3 = new Vector3D();

        double x, y, z;

        x = y = z = 0;
        Console.WriteLine("Enter coordinates for point to check against Plane.");
        Console.Write("X Value: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y Value: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Z Value: ");
        z = Convert.ToDouble(Console.ReadLine());
        Q.SetRectGivenRect(x, y, z);

        x = y = z = 0;
        Console.WriteLine("\nEnter coordinates for first point of the plane.");
        Console.Write("X Value: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y Value: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Z Value: ");
        z = Convert.ToDouble(Console.ReadLine());
        P1.SetRectGivenRect(x, y, z);

        x = y = z = 0;
        Console.WriteLine("\nEnter coordinates for second point of the plane.");
        Console.Write("X Value: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y Value: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Z Value: ");
        z = Convert.ToDouble(Console.ReadLine());
        P2.SetRectGivenRect(x, y, z);

        x = y = z = 0;
        Console.WriteLine("\nEnter coordinates for third point of the plane.");
        Console.Write("X Value: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y Value: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Z Value: ");
        z = Convert.ToDouble(Console.ReadLine());
        P3.SetRectGivenRect(x, y, z);

        Vector3D closestPoint = Q.ClosestPointOnPlane(P1, P2, P3);

        closestPoint.PrintRect();
        
        Vector3D mag = Q - closestPoint;
        Console.WriteLine("Distance from ship to ground: {0:F2} m.", mag.GetMagnitude());
    }

}
