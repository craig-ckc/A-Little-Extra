using A_little_Extra.Models;

namespace A_little_Extra.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                // Students default data
                if (!context.Students.Any())
                {
                    context.Students.AddRange(new List<Student>()
                    {
                        // add data here
                    });
                    context.SaveChanges();
                }

                // Department Staffs default data
                if (!context.DepartmentStaffs.Any())
                {
                    context.DepartmentStaffs.AddRange(new List<DepartmentStaff>()
                    {
                        // add data here
                    });
                    context.SaveChanges();
                }

                // University Patners default data
                if (!context.UniversityPatners.Any())
                {
                    context.UniversityPatners.AddRange(new List<UniversityPatner>()
                    {
                        // add data here
                    });
                    context.SaveChanges();
                }

                // Departments default data
                if (!context.Departments.Any())
                {
                    context.Departments.AddRange(new List<Department>()
                    {
                        // add data here
                    });
                    context.SaveChanges();
                }

                // Activities default data
                if (!context.Activities.Any())
                {
                    new Activity()
                    {
                        Name = "Newspaper Fashion",
                        Description = "Split students up into teams and hand out multiple copies of newspapers. Students work together to create a fashion show with their team. When it's time to share, remind them that the more dramatic and creative the better! ",
                        StartDate = Convert.ToDateTime("25/09/2022"),
                        EndDate = Convert.ToDateTime("01/10/2022"),
                        Points = 90,
                        UserId = 2,
                    };

                    new Activity()
                    {
                        Name = "The Ball and Bucket Challenge",
                        Description = "Similar to passing an orange down a line of people, using tennis balls or ping pong balls in plastic buckets the goal is to move the ball down a line of buckets without using arms or hands. Students have to work together as a team to communicate and move the balls along the row of buckets. ",
                        StartDate = Convert.ToDateTime("12/10/2022"),
                        EndDate = Convert.ToDateTime("17/10/2022"),
                        Points = 66,
                        UserId = 6,
                    };

                    new Activity()
                    {
                        Name = "Fun Run Across Campus",
                        Description = "Create a campus-wide event by holding a race, fun-run, or walkathon around school grounds. This is a great activity for mild or warmer fall and spring weather and is a great way to get students to exercise or to introduce new students to the entire campus.",
                        StartDate = Convert.ToDateTime("16/12/2022"),
                        EndDate = Convert.ToDateTime("21/12/2022"),
                        Points = 57,
                        UserId = 24,
                    };

                    new Activity()
                    {
                        Name = "Life After College Classes",
                        Description = "Students are stressed about what their life will be like outside of college, and you can help them by holding events and classes about life outside of college. Show students what it will be like searching for jobs, cooking, living with their parents, and other basic life skills they might not have learned yet.",
                        StartDate = Convert.ToDateTime("30/09/2022"),
                        EndDate = Convert.ToDateTime("06/10/2022"),
                        Points = 49,
                        UserId = 21,
                    };

                    new Activity()
                    {
                        Name = "White Elephant Gift Parties",
                        Description = "Have a different kind of gift giving party around the holidays or just for fun. Get students to buy funny or non-essential items to give to each other randomly and play a game where students choose from the pile of gifts and pass around presents.",
                        StartDate = Convert.ToDateTime("09/12/2022"),
                        EndDate = Convert.ToDateTime("14/12/2022"),
                        Points = 84,
                        UserId = 4,
                    };

                    new Activity()
                    {
                        Name = "Cooking Lessons",
                        Description = "Many students enjoy making meals for themselves and their friends while others might not be used to cooking and want to learn. Setup a one-time event or weekly cooking classes for students to take. They will like learning to make and eat food other than what they typically get at the dining hall.",
                        StartDate = Convert.ToDateTime("28/11/2022"),
                        EndDate = Convert.ToDateTime("03/12/2022"),
                        Points = 64,
                        UserId = 19,
                    };

                    new Activity()
                    {
                        Name = "Paint and Art Classes",
                        Description = "A quiet activity that many students love is painting and drawing. Create some Bob Ross style classes for students to follow along with an instructor or sketch at their own pace. Art classes are a great way to relieve stress and offer something fun for more introverted students.",
                        StartDate = Convert.ToDateTime("09/12/2022"),
                        EndDate = Convert.ToDateTime("14/12/2022"),
                        Points = 66,
                        UserId = 6,
                    };

                    new Activity()
                    {
                        Name = "Murder Mystery Nights",
                        Description = "Something unique and fun that students will be curious to attend is having a murder mystery night. Create several characters and break students off into groups and figure out which one of the characters is the culprit. There are several games you can buy to set this up.",
                        StartDate = Convert.ToDateTime("29/10/2022"),
                        EndDate = Convert.ToDateTime("30/10/2022"),
                        Points = 96,
                        UserId = 14,
                    };

                    new Activity()
                    {
                        Name = "Bus Trips to Nearby Cities or Parks",
                        Description = "If you are close to a city, a famous park, or somewhere else the students can spend a day, offer bus trips to that destination for students to spend some time away from campus. This gives students who do not have cars a chance to go out and do something different.",
                        StartDate = Convert.ToDateTime("21/11/2022"),
                        EndDate = Convert.ToDateTime("27/11/2022"),
                        Points = 30,
                        UserId = 10,
                    };

                    new Activity()
                    {
                        Name = "Blood Donation Setups",
                        Description = "Have students give back to the community by having a blood drive around campus for students to donate blood. Make an entire event out of it so that students are more likely to sign up or volunteer. Give them incentives for donating their blood so that itâ€™s more fun.",
                        StartDate = Convert.ToDateTime("10/11/2022"),
                        EndDate = Convert.ToDateTime("15/11/2022"),
                        Points = 21,
                        UserId = 11,
                    };

                    new Activity()
                    {
                        Name = "Food/Toy/Clothing Drives",
                        Description = "Another event to hold during charity themed weeks is a drive for such items as toys, food, and clothing. Encourage students to purchase items that can be given away to those in need or to donate some things they do not want or use anymore. Have some incentives for the class or dorm that gives away the most.",
                        StartDate = Convert.ToDateTime("07/10/2022"),
                        EndDate = Convert.ToDateTime("11/10/2022"),
                        Points = 38,
                        UserId = 30,
                    };

                    new Activity()
                    {
                        Name = "Groups Volunteer in the Town/City",
                        Description = "Separate students into different groups and send them off to various destinations around town where they can volunteer, such as at food banks, doing trash pickup, and at senior citizen homes. This is a go-to activity if your school has a charity themed week or month.",
                        StartDate = Convert.ToDateTime("03/11/2022"),
                        EndDate = Convert.ToDateTime("08/11/2022"),
                        Points = 97,
                        UserId = 5,
                    };

                    new Activity()
                    {
                        Name = "Live Concerts",
                        Description = "Schedule a concert in an auditorium or outdoors on the lawn with either school bands or a band that is currently touring. This is a great event to hold during spirit weeks or for fundraisers. Sell tickets to students with proceeds going to the school or offer them a free concert.",
                        StartDate = Convert.ToDateTime("01/12/2022"),
                        EndDate = Convert.ToDateTime("06/12/2022"),
                        Points = 72,
                        UserId = 21,
                    };

                    new Activity()
                    {
                        Name = "Garden with Students",
                        Description = "Reserve a spot on the grounds for students to grow their own flowers and plants, or have a vendor come to campus and sell plants for students to place in their dorm rooms, such as desk-sized plants like succulents. Plants are a great way of decorating the dorm rooms and small apartments students live in.",
                        StartDate = Convert.ToDateTime("07/11/2022"),
                        EndDate = Convert.ToDateTime("09/11/2022"),
                        Points = 54,
                        UserId = 16,
                    };

                    new Activity()
                    {
                        Name = "End of the Year Carnivals",
                        Description = "Congratulate your students for getting through the year by having a carnival on campus, complete with games where they can win prizes, a petting zoo, and rides. This option is a perfect day-long event and will be a special reward to students after their hard work.",
                        StartDate = Convert.ToDateTime("07/10/2022"),
                        EndDate = Convert.ToDateTime("09/10/2022"),
                        Points = 52,
                        UserId = 4,
                    };

                    new Activity()
                    {
                        Name = "Trip to Pumpkin Patch",
                        Description = "When the fall season is approaching, offer students bus trips away from campus to local pumpkin patches or apple orchards. You can also find an orchard that does hayrides, corn mazes, carnival style rides, and other activities associated with fall festivals.",
                        StartDate = Convert.ToDateTime("05/12/2022"),
                        EndDate = Convert.ToDateTime("10/12/2022"),
                        Points = 92,
                        UserId = 23,
                    };

                    new Activity()
                    {
                        Name = "DIY Crafts",
                        Description = "Set up crafting stations in dorm rooms for students to create their DIY crafts. Have a contest where all the students make the same thing or have each student try something different that they would not normally make. Look on Pinterest for some crafting inspirations.",
                        StartDate = Convert.ToDateTime("01/09/2022"),
                        EndDate = Convert.ToDateTime("08/09/2022"),
                        Points = 82,
                        UserId = 4,
                    };

                    new Activity()
                    {
                        Name = "Farmers Market Vendors",
                        Description = "Set up your own food market on campus by having a farmerâ€™s market event where students can show up and shop for locally made food. Get some vendors to install a custom canopy tent for events on a sidewalk or lawn so that students have a large selection to choose from.",
                        StartDate = Convert.ToDateTime("15/12/2022"),
                        EndDate = Convert.ToDateTime("19/12/2022"),
                        Points = 24,
                        UserId = 25,
                    };

                    new Activity()
                    {
                        Name = "Bingo with Prizes",
                        Description = "While Bingo might seem old-fashioned, you will be surprised how many students are willing to try their luck with the game, especially if school prizes and discount coupons are offered as incentives. You can also find themed Bingo cards instead of the classic game with numbers.",
                        StartDate = Convert.ToDateTime("23/12/2022"),
                        EndDate = Convert.ToDateTime("29/12/2022"),
                        Points = 65,
                        UserId = 13,
                    };

                    new Activity()
                    {
                        Name = "Weekly Trivia",
                        Description = "Host an evening of trivia for students to compete against each other for prizes. Include questions about the school, history, the latest news, pop culture, or whatever topic you want. Have students play in teams or by themselves and make it a weekly or monthly tournament.",
                        StartDate = Convert.ToDateTime("18/09/2022"),
                        EndDate = Convert.ToDateTime("19/09/2022"),
                        Points = 28,
                        UserId = 30,
                    };
                    context.SaveChanges();
                }

                // Awards default data
                if (!context.Awards.Any())
                {
                    context.Awards.AddRange(new List<Award>()
                    {
                        // add data here
                    });
                    context.SaveChanges();
                }

                // Student Awards default data
                if (!context.StudentAwards.Any())
                {
                    context.StudentAwards.AddRange(new List<StudentAward>()
                    {
                        // add data here
                    });
                    context.SaveChanges();
                }

                // Activity Participations default data
                if (!context.ActivityParticipations.Any())
                {
                    context.ActivityParticipations.AddRange(new List<ActivityParticipation>()
                    {
                        // add data here
                    });
                    context.SaveChanges();
                }

                // Activity Supervisions default data
                if (!context.ActivitySupervisions.Any())
                {
                    context.ActivitySupervisions.AddRange(new List<ActivitySupervision>()
                    {
                        // add data here
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
