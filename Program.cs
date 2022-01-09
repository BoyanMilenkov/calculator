using System;

namespace calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("SquareCircuit");
                Console.WriteLine("SquareArea");
                Console.WriteLine("TriangleArea");
                Console.WriteLine("RectangleCircuit");
                Console.WriteLine("RectangleArea");
                Console.WriteLine("CircleCircuit");
                Console.WriteLine("CircleArea");
                Console.WriteLine("CylinderMass");
                //Console.WriteLine("CylinderAreaOfTheBase");
                //Console.WriteLine("CylinderAreaofTheSurroundingSurface");
                Console.WriteLine("CylinderSurface");
                Console.WriteLine("CubeMass");
                Console.WriteLine("Is the rectangle, actually rectangle? If yes = true, if not = false.");
                Console.WriteLine("The sides of a rectangles:");
                Console.WriteLine("Comparing");
             
            
                int option;
                int.TryParse(Console.ReadLine(), out option);
                double sideA;
                double sideB;
                double sideC;
                double sideD;
                double height;
                double radius;
                
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter side:");
                        sideA = double.Parse(Console.ReadLine());
                        Square result = new Square(sideA);
                        Console.WriteLine("The result:");
                        Console.WriteLine(result.SquareCircuit(sideA));
                        break;
                    case 2:
                        Console.WriteLine("Enter side:");
                        sideA = double.Parse(Console.ReadLine());
                        Square resultTwo = new Square(sideA);
                        Console.WriteLine("The result:");
                        Console.WriteLine(resultTwo.SquareArea(sideA));
                        break;
                    case 3:
                        sideA = double.Parse(Console.ReadLine());
                        height = double.Parse(Console.ReadLine());
                        Triangle resultThree = new Triangle(sideA, height);
                        Console.WriteLine("The result:");
                        Console.WriteLine(resultThree.TriangleArea(sideA, height));
                        break;
                    case 4:
                        Console.WriteLine("Enter side:");
                        sideA = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second side:");
                        sideB = double.Parse(Console.ReadLine());
                        Rectangle resultFour = new Rectangle(sideA, sideB);
                        Console.WriteLine("The result:");
                        Console.WriteLine(resultFour.RectangleCircuit(sideA,sideB));
                        break;
                    case 5:
                        Console.WriteLine("Enter side:");
                        sideA = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second side:");
                        sideB = double.Parse(Console.ReadLine());
                        Rectangle resultFive = new Rectangle(sideA, sideB);
                        Console.WriteLine("The result:");
                        Console.WriteLine(resultFive.RectangleArea(sideA, sideB));
                        break;
                    case 6:
                        Console.WriteLine("Enter Radius:");
                        radius = double.Parse(Console.ReadLine());
                        Cycle resultSix = new Cycle(radius);
                        Console.WriteLine("The result:");
                        Console.WriteLine(resultSix.CircleCircuit(radius));
                        break; 
                    case 7:
                        Console.WriteLine("Enter Radius:");
                        radius = double.Parse(Console.ReadLine());
                        Cycle resultSeven = new Cycle(radius);
                        Console.WriteLine("The result:");
                        Console.WriteLine(resultSeven.CircleArea(radius));
                        break;
                    case 8:
                        Console.WriteLine("Enter Radius:");
                        radius = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Height:");
                        height = double.Parse(Console.ReadLine());
                        Cylinder resultEight = new Cylinder(radius, height);
                        Console.WriteLine("The result:");
                        Console.WriteLine(resultEight.CylinderMass(radius, height));
                        break;
                    //case 9:
                    //    radius = double.Parse(Console.ReadLine());
                    //    height = double.Parse(Console.ReadLine());
                    //    Cylinder resultNine = new Cylinder(radius, height);
                    //    break;
                    //case 10:
                    //    radius = double.Parse(Console.ReadLine());
                    //    height = double.Parse(Console.ReadLine());
                        
                    //    break; 
                    case 9:
                        Console.WriteLine("Enter Radius:");
                        radius = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Height:");
                        height = double.Parse(Console.ReadLine());
                        Cylinder resultNine = new Cylinder(radius, height);
                        Console.WriteLine("The result:");
                        Console.WriteLine(resultNine.CylinderSurface(radius, height));
                        break;
                    case 10:
                        Console.WriteLine("Enter side:");
                        sideA = double.Parse(Console.ReadLine());
                        Cube resultTwelve = new Cube(sideA);
                        Console.WriteLine("The result:");
                        Console.WriteLine(resultTwelve.CubeMass(sideA));
                        break;
                    case 11:
                        Console.WriteLine("First side:");
                        sideA = double.Parse(Console.ReadLine());
                        Console.WriteLine("Second side:");
                        sideB = double.Parse(Console.ReadLine());
                        Generic<double> resultSmth = new Generic<double>(sideA, sideB);
                        if(sideA == sideB)
                        {
                            Console.WriteLine(resultSmth.Equal());
                        }
                        else if(sideA != sideB)
                        {
                            Console.WriteLine(resultSmth.Equal());
                        }
                        break;
                    case 12:
                        Console.WriteLine("The first side:");
                        sideA = double.Parse(Console.ReadLine());
                        Console.WriteLine("The second side:");
                        sideB = double.Parse(Console.ReadLine());
                        //Console.WriteLine("The third side:");
                        //sideC = double.Parse(Console.ReadLine());
                        //Console.WriteLine("The fourth side:");
                        //sideD = double.Parse(Console.ReadLine());
                        Rectangle rectangleOne = new Rectangle(sideA, sideB);
                        //Rectangle rectangleTwo = new Rectangle(sideC, sideD);
                        
                        Enumarable enumarableTwo = new Enumarable(rectangleOne); 
                        foreach(var enumarable in enumarableTwo)
                        {
                            Console.WriteLine("The sides:");
                            Console.WriteLine(enumarable.SideA + " - side one");
                            Console.WriteLine(enumarable.SideB + " - side two");

                        }
                        break;
                    case 13:
                        Console.WriteLine("The first side for the first rectangle:");
                        sideA = double.Parse(Console.ReadLine());
                        Console.WriteLine("The second side for the first rectangle:");
                        sideB = double.Parse(Console.ReadLine());
                        Console.WriteLine("The first side for the second rectangle:");
                        sideC = double.Parse(Console.ReadLine());
                        Console.WriteLine("The second side for the second rectangle:");
                        sideD = double.Parse(Console.ReadLine());
                        Icomp rectOne = new Icomp(sideA, sideB);
                        Icomp rectTwo = new Icomp(sideC, sideD);
                        
                        if(rectOne.SideA == rectTwo.SideA && rectOne.SideB == rectTwo.SideB || rectOne.SideA == rectTwo.SideB && rectOne.SideB == rectTwo.SideA)
                        {
                            Console.WriteLine("The rectangles are equal");
                        }
                        else if(rectOne.SideA != rectTwo.SideA && rectOne.SideB != rectTwo.SideB || rectOne.SideA != rectTwo.SideB && rectOne.SideB != rectTwo.SideA)
                        {
                            Console.WriteLine("The rectangles are not equal");
                        }
                        break;
                    
                    
                }
                Console.WriteLine("Press any key to continue..");
                Console.ReadLine();
            }
            

        }
    }
}
