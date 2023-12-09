namespace LastPractosik
{
    internal class Authorization
    {
        public void Authoriz()
        {
            List<Polzovatel>? users;
            List<Admin> admin = new List<Admin>();
            while (true)
            {
                int pos, passwordPos;
                string? login = "";
                string password = "";
                ConsoleKeyInfo key;
                Console.SetCursorPosition(45, 0);
                Console.WriteLine("Добро пожаловать в магазин");
                for (int i = 0; i < 120; i++)
                    Console.Write("-");
                Console.WriteLine("  Логин:");
                Console.WriteLine("  Пароль:");
                Console.WriteLine("  Авторизоваться");

                users = jsonciki.Deserialize<Polzovatel>("path_to_json_file");

                while (true)
                {
                    pos = Key.CheckPos(2, 4);
                    if (pos == 2)
                    {
                        Console.SetCursorPosition(9, 2);
                        Console.Write(
                            "                                                                                ");
                        Console.SetCursorPosition(9, 2);
                        login = Console.ReadLine();
                    }

                    if (pos == 3)
                    {
                        password = "";
                        passwordPos = 10;
                        Console.SetCursorPosition(10, 3);
                        Console.Write(
                            "                                                                                ");
                        Console.SetCursorPosition(10, 3);
                        key = Console.ReadKey(true);
                        while (key.Key != ConsoleKey.Enter)
                        {
                            if (key.Key != ConsoleKey.Backspace)
                            {
                                password += key.KeyChar;
                                
                                passwordPos++;
                                Console.Write("*");
                            }
                            else if (key.Key == ConsoleKey.Backspace)
                            {
                                if (!string.IsNullOrEmpty(password))
                                {
                                    password = password.Substring(0, password.Length - 1);
                                    passwordPos--;
                                    Console.SetCursorPosition(passwordPos, 3);
                                    Console.Write(" ");
                                    Console.SetCursorPosition(passwordPos, 3);
                                }
                            }

                            key = Console.ReadKey(true);
                        }
                    }

                    if (pos == 4 && login != "" && password != "")
                    {
                        admin = jsonciki.Deserialize<Admin>("User.json");
                        if (admin != null)
                        {
                            foreach (Admin user in admin)
                            {
                                if (user.login == login && user.password == password && user.Role == Roli.Admin)
                                {
                                    admin.AdminPanel(login);
                                    break;
                                }
                            }
                        }
                    }

                }
            }
        }
    }
}
