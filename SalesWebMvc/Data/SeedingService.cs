using System;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
using System.Linq;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() ||
                _context.SalesRecord.Any()) 
            {
                return; 
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob", "bob@gmail.com", new DateTime(1998,4 , 21), 1000, d1);
            Seller s2 = new Seller(2, "Maria", "Maria@gmail.com", new DateTime(1982, 5, 12), 1000, d2);
            Seller s3 = new Seller(3, "Joao", "joao@gmail.com", new DateTime(1977, 1, 1), 1100, d3);
            Seller s4 = new Seller(4, "Jose", "jose@gmail.com", new DateTime(1995, 2, 10), 1000, d4);
            Seller s5 = new Seller(5, "Pedro", "pedro@gmail.com", new DateTime(1988, 10, 5), 1000, d1);
            Seller s6 = new Seller(6, "Joana", "joana@gmail.com", new DateTime(1992, 5, 2), 1000, d3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2021, 01 , 25), 11000, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2021, 01, 25), 10000, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2021, 02, 1), 15000, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2021, 02, 2), 9000, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2021, 03, 3), 5000, SaleStatus.Billed, s4);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2021, 03, 5), 2000, SaleStatus.Billed, s5);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2021, 04, 10), 1000, SaleStatus.Billed, s6);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 05, 12), 1100, SaleStatus.Billed, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2021, 06, 15), 10000, SaleStatus.Billed, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2021, 07, 5), 20000, SaleStatus.Billed, s4);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2021, 01, 30), 25000, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2021, 02, 21), 10000, SaleStatus.Billed, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2021, 03, 12), 13000, SaleStatus.Billed, s2);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2021, 04, 11), 1000, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2021, 05, 1), 11600, SaleStatus.Billed, s6);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2021, 06, 8), 11400, SaleStatus.Billed, s1);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2021, 07, 18), 11200, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2021, 05, 26), 35000, SaleStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2021, 06, 28), 10000, SaleStatus.Billed, s2);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2021, 07, 27), 500, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20);

            _context.SaveChanges();
        }
    }
}
