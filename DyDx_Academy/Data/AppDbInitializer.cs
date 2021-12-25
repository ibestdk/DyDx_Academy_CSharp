using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DyDx_Academy.Data.Static;
using DyDx_Academy.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace DyDx_Academy.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuiler)
        {
            using (var serviceScpoe = applicationBuiler.ApplicationServices.CreateScope())
            {
                var context = serviceScpoe.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                //Instructor
                if (!context.Instructors.Any())
                {
                    context.Instructors.AddRange(new List<Instructors>()
                    {
                        new Instructors()
                        {
                            FullName = "Peerawit Vongsinpratueng",
                            Bio = "    - 3rd year of B.Eng (Computer Engineer) DPU - First-runner up of Thailand 4.0 ioT Project Competition (2018) at KMUTNB - ioT and AWS Teaching Assistant at DPU - Web Developer and Web Tester Intern at T Capital Technology Co. Ltd ",
                            ProfilePictureURL = "https://dydx-academy-s3.s3.ap-southeast-1.amazonaws.com/Web-img-resource/instructor/hidekun.jpg"

                        },
                        new Instructors()
                        {
                            FullName = "Jirat Deekhum",
                            Bio = "    - 3rd year of B.Eng (Computer Engineer)- Web Developer Intern at T Capital Technology Co. Ltd - Fullstack Web Devoloper - Web Founder & Lead Developer of AdopPix",
                            ProfilePictureURL = "https://dydx-academy-s3.s3.ap-southeast-1.amazonaws.com/Web-img-resource/instructor/ibestdk.jpg"
                        },
                        new Instructors()
                        {
                            FullName = "Suppavit Vilikit",
                            Bio = "    - 3rd year of B.Eng (Computer Engineer) - Web Developer Intern at T Capital Technology Co. Ltd - business analyst at Buzzfreed Solution Software House- Front-end Web Dev",
                            ProfilePictureURL = "https://dydx-academy-s3.s3.ap-southeast-1.amazonaws.com/Web-img-resource/instructor/suppavit1412.jpg"
                        },
                    });
                    context.SaveChanges();
                }


                //Courses
                if (!context.Courses.Any())
                {
                    context.Courses.AddRange(new List<Courses>()
                    {
                        new Courses()
                        {
                            Name = "HTML 101",
                            Description = "มาเริ่มต้นทำเว็บด้วย HTML อย่างง่ายกันเถอะ!",
                            Price = 399,
                            ImageURL = "https://dydx-academy-s3.s3.ap-southeast-1.amazonaws.com/Web-img-resource/course/course/html.jpg",
                            Create = DateTime.Now,
                            CourseCategory = CourseCategory.Web_Developer
                        },
                        new Courses()
                        {
                            Name = "CSS 101",
                            Description = "มาทำให้เว็บไซต์ของคุณดูสวยงามด้วย css กันเถอะ!",
                            Price = 399,
                            ImageURL = "https://dydx-academy-s3.s3.ap-southeast-1.amazonaws.com/Web-img-resource/course/course/CSS.jpg",
                            Create = DateTime.Now,
                            CourseCategory = CourseCategory.Web_Developer
                        },
                        new Courses()
                        {
                            Name = "JavaScript 101",
                            Description = "เรียนรู้และพัฒนาสู่การเป็น Developer กับการเขียน Javascript กันเถอะ!",
                            Price = 399,
                            ImageURL = "https://dydx-academy-s3.s3.ap-southeast-1.amazonaws.com/Web-img-resource/course/course/javascript.jpg",
                            Create = DateTime.Now,
                            CourseCategory = CourseCategory.Web_Developer
                        },
                        new Courses()
                        {
                            Name = "Race",
                            Description = "มาสนุกไปกับการทำ Application บนสมาร์ทโฟนสุดเก๋ไก๋กันเถอะ!",
                            Price = 450,
                            ImageURL = "https://dydx-academy-s3.s3.ap-southeast-1.amazonaws.com/Web-img-resource/course/course/flutter-course.jpg",
                            Create = DateTime.Now,
                            CourseCategory = CourseCategory.Mobile_Developer
                        },
                        new Courses()
                        {
                            Name = "Basic Microsoft Azure AZ-900 Exam",
                            Description = "คอสของเราจะเพิ่มทักษะของคุณให้เป็น Cloud Developer ของ Microsoft Azure อย่างเต็มประสิทธิภาพ เเละเตรียมพร้อมกับการสอบ Azure Certifications อีกด้วย",
                            Price = 599,
                            ImageURL = "https://dydx-academy-s3.s3.ap-southeast-1.amazonaws.com/Web-img-resource/course/course/arzure-course.jpg",
                            Create = DateTime.Now,
                            CourseCategory = CourseCategory.Arzure
                        },
                        new Courses()
                        {
                            Name = "Arduino 101 ",
                            Description = "Arduino 101 ที่จะทำให้คุณสนุกเพลิดเพลินไปกับอุปกรณ์ IoT ต่างๆรอบตัวคุณ",
                            Price = 299,
                            ImageURL = "https://dydx-academy-s3.s3.ap-southeast-1.amazonaws.com/Web-img-resource/course/course/arduino-course.jpg",
                            Create = DateTime.Now,
                            CourseCategory = CourseCategory.Arduino
                        }
                    });
                    context.SaveChanges();
                }

                //Instructor_Course
                if (!context.Instructor_Course.Any())
                {
                    context.Instructor_Course.AddRange(new List<Instructor_Course>()
                    {
                        new Instructor_Course()
                        {
                            InstructorId = 3,
                            CourseId = 1
                        },

                         new Instructor_Course()
                        {
                            InstructorId = 3,
                            CourseId = 2
                        },


                        new Instructor_Course()
                        {
                            InstructorId = 3,
                            CourseId = 3
                        },



                        new Instructor_Course()
                        {
                            InstructorId = 1,
                            CourseId = 4
                        },



                        new Instructor_Course()
                        {
                            InstructorId = 1,
                            CourseId = 5
                        },



                        new Instructor_Course()
                        {
                            InstructorId = 1,
                            CourseId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
