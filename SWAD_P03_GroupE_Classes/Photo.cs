using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_P03_GroupE_Classes
{
    public class Photo
    {
            public string PhotoID { get; set; }

            // Constructor for Photo class
            public Photo(string photoID)
            {
                if (string.IsNullOrWhiteSpace(photoID))
                {
                    throw new ArgumentException("Photo ID cannot be empty.", nameof(photoID));
                }

                PhotoID = photoID;
            }

            // Simulate photo creation
            public static Photo CreatePhoto()
            {
                Console.Write("Enter Photo ID: ");
                string photoID = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(photoID))
                {
                    Console.WriteLine("Photo ID cannot be empty.");
                    return null;
                }

                return new Photo(photoID);
            }
        }
    }