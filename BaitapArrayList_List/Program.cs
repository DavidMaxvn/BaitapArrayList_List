using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapArrayList_List
{

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Khởi tạo mảng
            Item[] items = new Item[20]
            {
            new Item { Id = 1, Name = "Item 1", Price = 10.5, CreatedDate = DateTime.Now.AddDays(-1), IsActive = true },
            new Item { Id = 2, Name = "Item 2", Price = 21.0, CreatedDate = DateTime.Now.AddDays(-2), IsActive = false },
            new Item { Id = 3, Name = "Item 3", Price = 31.5, CreatedDate = DateTime.Now.AddDays(-3), IsActive = true },
            new Item { Id = 4, Name = "Item 4", Price = 42.0, CreatedDate = DateTime.Now.AddDays(-4), IsActive = false },
            new Item { Id = 5, Name = "Item 5", Price = 52.5, CreatedDate = DateTime.Now.AddDays(-5), IsActive = true },
            new Item { Id = 6, Name = "Item 6", Price = 63.0, CreatedDate = DateTime.Now.AddDays(-6), IsActive = false },new Item { Id = 7, Name = "Item 7", Price = 73.5, CreatedDate = DateTime.Now.AddDays(-7), IsActive = true },
            new Item { Id = 8, Name = "Item 8", Price = 84.0, CreatedDate = DateTime.Now.AddDays(-8), IsActive = false },
            new Item { Id = 9, Name = "Item 9", Price = 94.5, CreatedDate = DateTime.Now.AddDays(-9), IsActive = true },
            new Item { Id = 10, Name = "Item 10", Price = 105.0, CreatedDate = DateTime.Now.AddDays(-10), IsActive = false },
            new Item { Id = 11, Name = "Item 11", Price = 115.5, CreatedDate = DateTime.Now.AddDays(-11), IsActive = true },
            new Item { Id = 12, Name = "Item 12", Price = 126.0, CreatedDate = DateTime.Now.AddDays(-12), IsActive = false },
            new Item { Id = 13, Name = "Item 13", Price = 136.5, CreatedDate = DateTime.Now.AddDays(-13), IsActive = true },
            new Item { Id = 14, Name = "Item 14", Price = 147.0, CreatedDate = DateTime.Now.AddDays(-14), IsActive = false },
            new Item { Id = 15, Name = "Item 15", Price = 157.5, CreatedDate = DateTime.Now.AddDays(-15), IsActive = true },
            new Item { Id = 16, Name = "Item 16", Price = 168.0, CreatedDate = DateTime.Now.AddDays(-16), IsActive = false },
            new Item { Id = 17, Name = "Item 17", Price = 178.5, CreatedDate = DateTime.Now.AddDays(-17), IsActive = true },
            new Item { Id = 18, Name = "Item 18", Price = 189.0, CreatedDate = DateTime.Now.AddDays(-18), IsActive = false },
            new Item { Id = 19, Name = "Item 19", Price = 199.5, CreatedDate = DateTime.Now.AddDays(-19), IsActive = true },
            new Item { Id = 20, Name = "Item 20", Price = 210.0, CreatedDate = DateTime.Now.AddDays(-20), IsActive = false }
            };

            // Hiển thị danh sách mảng
            // Hiển thị tiêu đề
            Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}", "ID", "Name", "Price", "Created Date", "IsActive");
            Console.WriteLine(new string('-', 80)); // Dòng kẻ ngăn cách

            // Hiển thị danh sách mảng
            foreach (var item in items)
            {
                Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                    item.Id, item.Name, item.Price, item.CreatedDate.ToString("dd/MM/yyyy"), item.IsActive ? "Active" : "Inactive");
            }

            // Chuyển đổi mảng sang ArrayList
            ArrayList arrayListItems = new ArrayList(items);

            // Chuyển đổi mảng sang List<Item>
            List<Item> listItems = new List<Item>(items);

            // Hiển thị danh sách ArrayList
            Console.WriteLine("\nDanh sách ArrayList:");
            foreach (Item item in arrayListItems)
            {
                Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                    item.Id, item.Name, item.Price, item.CreatedDate.ToString("dd/MM/yyyy"), item.IsActive ? "Active" : "Inactive");
            }

            // Hiển thị danh sách List<Item>
            Console.WriteLine("\nDanh sách List<Item>:");
            foreach (Item item in listItems)
            {
                Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                    item.Id, item.Name, item.Price, item.CreatedDate.ToString("dd/MM/yyyy"), item.IsActive ? "Active" : "Inactive");
            }

            // Hiển thị tổng số lượng phần tử đã thêm vào
            Console.WriteLine($"\nTổng số lượng phần tử đã thêm vào ArrayList: {arrayListItems.Count}");
            Console.WriteLine($"Tổng số lượng phần tử đã thêm vào List: {listItems.Count}");


            // Tìm kiếm phần tử theo ID
            // Tìm kiếm phần tử có Id = 10 trong ArrayList
            Console.WriteLine("\nTìm kiếm phần tử có Id = 10 trong ArrayList:");
            int indexArrayList = -1;
            Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}", "ID", "Name", "Price", "Created Date", "IsActive");
            Console.WriteLine(new string('-', 80));
            for (int i = 0; i < arrayListItems.Count; i++)
            {
                Item item = (Item)arrayListItems[i];
                if (item.Id == 10)
                {
                    indexArrayList = i;
                    Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                        item.Id, item.Name, item.Price, item.CreatedDate.ToString("dd/MM/yyyy"), item.IsActive ? "Active" : "Inactive");
                    Console.WriteLine($"Vị trí của phần tử trong ArrayList: {indexArrayList}");
                    break;
                }
            }
            if (indexArrayList == -1)
            {
                Console.WriteLine("Không tìm thấy phần tử có Id = 10 trong ArrayList.");
            }

            // Tìm kiếm phần tử có Id = 10 trong List<Item>
            Console.WriteLine("\nTìm kiếm phần tử có Id = 10 trong List<Item>:");
            int indexList = -1;
            Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}", "ID", "Name", "Price", "Created Date", "IsActive");
            Console.WriteLine(new string('-', 80));
            for (int i = 0; i < listItems.Count; i++)
            {
                if (listItems[i].Id == 10)
                {
                    indexList = i;
                    Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                        listItems[i].Id, listItems[i].Name, listItems[i].Price, listItems[i].CreatedDate.ToString("dd/MM/yyyy"), listItems[i].IsActive ? "Active" : "Inactive");
                    Console.WriteLine($"Vị trí của phần tử trong List<Item>: {indexList}");
                    break;
                }
            }
            if (indexList == -1)
            {
                Console.WriteLine("Không tìm thấy phần tử có Id = 10 trong List<Item>.");
            }

            // Xóa phần tử có Price nhỏ hơn 100.0 trong ArrayList
            for (int i = arrayListItems.Count - 1; i >= 0; i--)
            {
                Item item = (Item)arrayListItems[i];
                if (item.Price < 100.0)
                {
                    arrayListItems.RemoveAt(i);
                }
            }

            // Hiển thị danh sách ArrayList sau khi xóa
            Console.WriteLine("\nDanh sách ArrayList sau khi xóa các phần tử có Price < 100.0:");
            foreach (Item item in arrayListItems)
            {
                Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                    item.Id, item.Name, item.Price, item.CreatedDate.ToString("dd/MM/yyyy"), item.IsActive ? "Active" : "Inactive");
            }

            // Xóa phần tử có Price nhỏ hơn 100.0 trong List<Item>
            listItems.RemoveAll(item => item.Price < 100.0);

            // Hiển thị danh sách List<Item> sau khi xóa
            Console.WriteLine("\nDanh sách List<Item> sau khi xóa các phần tử có Price < 100.0:");
            foreach (Item item in listItems)
            {
                Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                    item.Id, item.Name, item.Price, item.CreatedDate.ToString("dd/MM/yyyy"), item.IsActive ? "Active" : "Inactive");
            }

            // Hiển thị danh sách các phần tử có IsActive = true trong ArrayList
            Console.WriteLine("\nDanh sách ArrayList với IsActive = True:");
            foreach (Item item in arrayListItems)
            {
                if (item.IsActive)
                {
                    Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                        item.Id, item.Name, item.Price, item.CreatedDate.ToString("dd/MM/yyyy"), item.IsActive ? "Active" : "Inactive");
                }
            }

            // Hiển thị danh sách các phần tử có IsActive = true trong List<Item>
            Console.WriteLine("\nDanh sách List<Item> với IsActive = True:");
            foreach (Item item in listItems)
            {
                if (item.IsActive)
                {
                    Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                        item.Id, item.Name, item.Price, item.CreatedDate.ToString("dd/MM/yyyy"), item.IsActive ? "Active" : "Inactive");
                }
            }

            // Hiển thị danh sách sản phẩm có CreatedDate trong vòng 10 ngày trong ArrayList
            Console.WriteLine("\nDanh sách sản phẩm trong vòng 10 ngày (ArrayList):");
            foreach (Item item in arrayListItems)
            {
                if (item.CreatedDate <= DateTime.Now.AddDays(-10))
                {
                    Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                        item.Id, item.Name, item.Price, item.CreatedDate.ToString("dd/MM/yyyy"), item.IsActive ? "Active" : "Inactive");
                }
            }

            // Hiển thị danh sách sản phẩm có CreatedDate trong vòng 10 ngày trong List<Item>
            Console.WriteLine("\nDanh sách sản phẩm trong vòng 10 ngày (List<Item>):");
            foreach (Item item in listItems)
            {
                if (item.CreatedDate <= DateTime.Now.AddDays(-10))
                {
                    Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                        item.Id, item.Name, item.Price, item.CreatedDate.ToString("dd/MM/yyyy"), item.IsActive ? "Active" : "Inactive");
                }
            }

            // Sắp xếp ArrayList theo Price giảm dần, nếu trùng Price thì sắp xếp theo Name
            var sortedArrayList = arrayListItems.Cast<Item>()
                .OrderByDescending(item => item.Price)
                .ThenBy(item => item.Name)
                .ToList();

            // Hiển thị danh sách ArrayList đã sắp xếp
            Console.WriteLine("\nDanh sách ArrayList sắp xếp theo Price từ lớn đến nhỏ, nếu trùng Price thì theo Name:");
            foreach (Item item in sortedArrayList)
            {
                Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                    item.Id, item.Name, item.Price, item.CreatedDate.ToString("dd/MM/yyyy"), item.IsActive ? "Active" : "Inactive");
            }

            // Sắp xếp List<Item> theo Price giảm dần, nếu trùng Price thì sắp xếp theo Name
            var sortedListItems = listItems
                .OrderByDescending(item => item.Price)
                .ThenBy(item => item.Name)
                .ToList();

            // Hiển thị danh sách List<Item> đã sắp xếp
            Console.WriteLine("\nDanh sách List<Item> sắp xếp theo Price từ lớn đến nhỏ, nếu trùng Price thì theo Name:");
            foreach (Item item in sortedListItems)
            {
                Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                    item.Id, item.Name, item.Price, item.CreatedDate.ToString("dd/MM/yyyy"), item.IsActive ? "Active" : "Inactive");
            }

            // Nhập tên sản phẩm cần tìm kiếm
            Console.Write("\nNhập tên sản phẩm cần tìm: ");
            string searchName = Console.ReadLine();

            // Tìm kiếm sản phẩm trong ArrayList
            Console.WriteLine("\nKết quả tìm kiếm trong ArrayList:");
            bool foundInArrayList = false;
            foreach (Item item in arrayListItems)
            {
                if (item.Name.IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                        item.Id, item.Name, item.Price, item.CreatedDate.ToString("dd/MM/yyyy"), item.IsActive ? "Active" : "Inactive");
                    foundInArrayList = true;
                }
            }
            if (!foundInArrayList)
            {
                Console.WriteLine("Không tìm thấy sản phẩm nào trong ArrayList.");
            }

            // Tìm kiếm sản phẩm trong List<Item>
            Console.WriteLine("\nKết quả tìm kiếm trong List<Item>:");
            bool foundInList = false;
            foreach (Item item in listItems)
            {
                if (item.Name.IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                        item.Id, item.Name, item.Price, item.CreatedDate.ToString("dd/MM/yyyy"), item.IsActive ? "Active" : "Inactive");
                    foundInList = true;
                }
            }
            if (!foundInList)
            {
                Console.WriteLine("Không tìm thấy sản phẩm nào trong List<Item>.");
            }

            // Tính tổng giá tiền của tất cả sản phẩm trong ArrayList
            double totalPriceArrayList = 0.0;
            foreach (Item item in arrayListItems)
            {
                totalPriceArrayList += item.Price;
            }
            Console.WriteLine($"\nTổng giá tiền của tất cả sản phẩm trong ArrayList: {totalPriceArrayList}");

            // Tính tổng giá tiền của tất cả sản phẩm trong List<Item>
            double totalPriceList = 0.0;
            foreach (Item item in listItems)
            {
                totalPriceList += item.Price;
            }
            Console.WriteLine($"Tổng giá tiền của tất cả sản phẩm trong List<Item>: {totalPriceList}");


            // Tìm giá trị lớn nhất trong ArrayList
            double maxPriceArrayList = arrayListItems.Cast<Item>().Max(item => item.Price);

            // Lọc các sản phẩm có giá trị lớn nhất và sắp xếp theo CreatedDate
            var maxPriceItemsArrayList = arrayListItems.Cast<Item>()
                .Where(item => item.Price == maxPriceArrayList)
                .OrderBy(item => item.CreatedDate)
                .ToList();

            // Hiển thị kết quả
            Console.WriteLine($"\nSản phẩm có trị giá lớn nhất trong ArrayList ({maxPriceArrayList}):");
            foreach (Item item in maxPriceItemsArrayList)
            {
                Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                    item.Id, item.Name, item.Price, item.CreatedDate.ToString("dd/MM/yyyy"), item.IsActive ? "Active" : "Inactive");
            }

            // Tìm giá trị lớn nhất trong List<Item>
            double maxPriceList = listItems.Max(item => item.Price);

            // Lọc các sản phẩm có giá trị lớn nhất và sắp xếp theo CreatedDate
            var maxPriceItemsList = listItems
                .Where(item => item.Price == maxPriceList)
                .OrderBy(item => item.CreatedDate)
                .ToList();

            // Hiển thị kết quả
            Console.WriteLine($"\nSản phẩm có trị giá lớn nhất trong List<Item> ({maxPriceList}):");
            foreach (Item item in maxPriceItemsList)
            {
                Console.WriteLine("{0,-5} | {1,-10} | {2,-10} | {3,-20} | {4,-10}",
                    item.Id, item.Name, item.Price, item.CreatedDate.ToString("dd/MM/yyyy"), item.IsActive ? "Active" : "Inactive");
            }

            Console.ReadLine();
        }
    }
}
