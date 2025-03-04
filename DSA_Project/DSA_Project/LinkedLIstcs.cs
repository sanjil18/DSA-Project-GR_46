using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DSA_Project
{
    public class LinkedLIstcs
    {
        Node head = null;
        Node tail = null;
        int count = 0;
        public void ADD(double SGPA, int REGNO)
        {
            Node node = new Node(SGPA, REGNO);

            if (count == 0)
            {
                head = node;
                tail = node;
                count++;
                return;
            }
            else
            {
                tail.Next = node;
                node.Prev = tail;
                tail=node;
                count++;
                

            }

        }
        public void bubbleSort()
        {
            if (count == 0)
            {
                Console.WriteLine("No students added");
                return;
            }

            bool swapped;
            for (int i = 0; i < count - 1; i++)
            {
                swapped = false;
                Node temp = head;

                for (int j = 0; j < count - i - 1; j++)  
                {
                    if (temp.SGPA > temp.Next.SGPA)
                    {
                        
                        double tempSGPA = temp.SGPA;
                        temp.SGPA = temp.Next.SGPA;
                        temp.Next.SGPA = tempSGPA;

                        
                        int tempREGNO = temp.REGNO;
                        temp.REGNO = temp.Next.REGNO;
                        temp.Next.REGNO = tempREGNO;

                        swapped = true;
                    }
                    temp = temp.Next;
                }

                
                if (!swapped)
                    break;
            }
        }

        public void selectionSort()
        {
            Node temp1 = head;

            while (temp1.Next != null)
            {
                Node minNode = temp1;
                Node temp = temp1.Next;

                while (temp.Next != null)
                {
                    if (temp.SGPA < minNode.SGPA)
                    {
                        minNode = temp; 
                    }
                    temp = temp.Next;
                }

                
                if (minNode != temp1)
                {
                    double tempSGPA = temp1.SGPA;
                    int tempRegNo = temp1.REGNO;

                    temp1.SGPA = minNode.SGPA;
                    temp1.REGNO = minNode.REGNO;

                    minNode.SGPA = tempSGPA;
                    minNode.REGNO = tempRegNo;
                }

                temp1 = temp1.Next;
            }
        }

        public void InsertionSort()
        {
            if (head == null || head.Next == null)
            {
                return; // No need to sort if 0 or 1 node
            }

            Node sortedHead = null; // Sorted part of the list
            Node current = head;    // The node being inserted

            while (current != null)
            {
                Node next = current.Next; // Store next node

                InsertIntoSortedList(ref sortedHead, current); // Insert current into sorted list

                current = next; // Move to next node
            }

            head = sortedHead; // Update head to the sorted list
        }

        // Helper function to insert a node in sorted order
        private void InsertIntoSortedList(ref Node sorted, Node newNode)
        {
            if (sorted == null || newNode.SGPA < sorted.SGPA)
            {
                // Insert at the beginning
                newNode.Next = sorted;
                if (sorted != null) sorted.Prev = newNode;
                sorted = newNode;
                return;
            }

            // Find the correct position to insert
            Node current = sorted;
            while (current.Next != null && current.Next.SGPA < newNode.SGPA)
            {
                current = current.Next;
            }

            // Insert after current node
            newNode.Next = current.Next;
            if (current.Next != null) current.Next.Prev = newNode;

            current.Next = newNode;
            newNode.Prev = current;
        }



        public void FirstRank()
        {
            Console.WriteLine();
            if (tail == null)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No students available.");
                Console.ResetColor();
                Console.WriteLine();
                return;
            }

            double highestSGPA = tail.SGPA;
            Node? temp = tail;

            while (temp != null && temp.SGPA == highestSGPA)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The Student with Reg NO {temp.REGNO} has Highest SGPA: {temp.SGPA}");
                Console.ResetColor();
                temp = temp.Prev;
            }
        }

       
        public void DisplayAllStudents()
        {
            Node? temp = tail;
            int rank = 1;
            int count1 = 1;
            double prevSGPA = temp?.SGPA ?? -1;

            while (temp != null)
            {
                if (temp.SGPA != prevSGPA)
                {
                    rank = count1;
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Reg No: {temp.REGNO}, SGPA: {temp.SGPA}, Rank: {rank}");
                Console.ResetColor();
                Console.WriteLine();
                prevSGPA = temp.SGPA;
                count1++;
                temp = temp.Prev;
            }
        }

        
        public void FindSGPAandRank(int regno)
        {
            int rank = 1;
            Node? temp = tail;

            while (temp != null && temp.REGNO != regno)
            {
                temp = temp.Prev;
                rank++;
            }

            if (temp == null)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Reg NO not found.");
                Console.ResetColor();
                Console.WriteLine();
                return;
            }

            Node? checkTemp = temp.Next;
            while (checkTemp != null && checkTemp.SGPA == temp.SGPA)
            {
                rank--;
                checkTemp = checkTemp.Next;
            }
            Console.WriteLine() ;
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"The SGPA of Reg NO {temp.REGNO} is {temp.SGPA}, and the Rank is {rank}");
            Console.ResetColor();
            Console.WriteLine();
        }




        public void GetStudentDetails()
        {
            int e=1;
            Exceptional_handling expLink = new Exceptional_handling();
            while (e == 1)
            {

                int regno = expLink.GetValidInteger("Enter the student Registration Number: ");
                Node temp = head;
                while (temp != null)
                {
                    if(temp.REGNO==regno)
                    {
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("This Registration number system already have Please try with New Number ");
                        Console.ResetColor();
                        Console.WriteLine();
                         regno = expLink.GetValidInteger("Enter the student Registration Number: ");
                        break;

                    }
                    else
                    {
                        temp = temp.Next;
                    }
                }


                int semInt = expLink.GetValidInteger("Enter the Semester number: ");
                while (semInt > 8 || semInt < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter the Correct Semester number");
                    Console.ResetColor();
                    semInt = expLink.GetValidInteger("Enter the Semester number: ");
                    
                }
                double sem = Convert.ToDouble(semInt);

                double TotalGPA = 0.0;
                for (int i = 0; i < sem; i++)
                {
                    double GPA = expLink.GetValidDouble($"Enter the GPA for Semester {i + 1}:");
                    while (GPA > 4 || GPA < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter the Correct GPA");
                        Console.ResetColor();
                        GPA = expLink.GetValidDouble($"Enter the GPA for Semester {i + 1}:");
                    }

                    TotalGPA += GPA;
                }

                double SGPA = Math.Round(TotalGPA / sem, 3);


                Console.WriteLine();
                Console.WriteLine();
                e = expLink.GetValidInteger("If you need to add students, press 1. Otherwise, press any other number ( 0-9 ):");
                ADD(SGPA, regno);


                Console.WriteLine();
                Console.WriteLine();



            }
        }
    }
}
