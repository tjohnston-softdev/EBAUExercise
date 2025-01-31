﻿using System;
using System.Collections.Generic;
using EBAUExercise.Models;

namespace EBAUExercise.Repository
{
    public class SampleDataRepository
    {
        public List<CustomerOrder> GetDataset =>
            new List<CustomerOrder>
            {
                new CustomerOrder(1525296, 2196254, 482.1m, DateTime.Parse("30/03/2021 3:51")),
                new CustomerOrder(3015541, 2196264, 10m, DateTime.Parse("1/05/2020 1:33")),
                new CustomerOrder(3015541, 2196265, 27.95m, DateTime.Parse("28/03/2021 1:37")),
                new CustomerOrder(3015541, 2196266, 31.95m, DateTime.Parse("29/03/2021 1:38")),
                new CustomerOrder(3015541, 2196267, 28.45m, DateTime.Parse("31/03/2021 1:39")),
                new CustomerOrder(3021777, 2196261, 44.95m, DateTime.Parse("1/05/2020 1:31")),
                new CustomerOrder(3021777, 2196262, 110.85m, DateTime.Parse("30/03/2021 1:32")),
                new CustomerOrder(3021777, 2196263, 14.95m, DateTime.Parse("31/03/2021 1:33")),
                new CustomerOrder(3026415, 2196268, 15.3m, DateTime.Parse("1/05/2020 8:39")),
                new CustomerOrder(3026415, 2196240, 31.95m, DateTime.Parse("20/03/2021 1:00")),
                new CustomerOrder(3026415, 2196243, 13.95m, DateTime.Parse("24/03/2021 1:03")),
                new CustomerOrder(3026415, 2196269, 14.95m, DateTime.Parse("26/03/2021 5:40")),
                new CustomerOrder(3026415, 2196245, 28.45m, DateTime.Parse("28/03/2021 1:08")),
                new CustomerOrder(3026415, 2196272, 9.95m, DateTime.Parse("28/03/2021 1:46")),
                new CustomerOrder(3026415, 2196270, 13.95m, DateTime.Parse("28/03/2021 10:41")),
                new CustomerOrder(3026415, 2196235, 44.95m, DateTime.Parse("29/03/2021 0:52")),
                new CustomerOrder(3026415, 2196236, 110.85m, DateTime.Parse("29/03/2021 0:53")),
                new CustomerOrder(3026415, 2196241, 15.3m, DateTime.Parse("29/03/2021 1:02")),
                new CustomerOrder(3026415, 2196242, 14.95m, DateTime.Parse("29/03/2021 1:02")),
                new CustomerOrder(3026415, 2196273, 403.95m, DateTime.Parse("30/03/2021 1:49")),
                new CustomerOrder(3026415, 2196274, 39.95m, DateTime.Parse("31/03/2021 1:50")),
                new CustomerOrder(4436979, 2196244, 45.9m, DateTime.Parse("29/03/2021 1:04")),
                new CustomerOrder(4436979, 2196271, 45.9m, DateTime.Parse("31/03/2021 1:42")),
                new CustomerOrder(4442226, 2196239, 27.95m, DateTime.Parse("24/03/2021 0:59")),
                new CustomerOrder(4442226, 2196234, 45.9m, DateTime.Parse("29/03/2021 0:44")),
                new CustomerOrder(4442229, 2196247, 39.95m, DateTime.Parse("29/03/2021 1:25")),
                new CustomerOrder(4442230, 2196252, 45.9m, DateTime.Parse("29/03/2021 2:05")),
                new CustomerOrder(4442234, 2196237, 14.95m, DateTime.Parse("20/03/2021 0:53")),
                new CustomerOrder(4442234, 2196238, 10m, DateTime.Parse("29/03/2021 0:55")),
                new CustomerOrder(4442234, 2196255, 55.9m, DateTime.Parse("31/03/2021 1:10")),
                new CustomerOrder(4442235, 2196256, 39.95m, DateTime.Parse("31/03/2021 1:11")),
                new CustomerOrder(4442241, 2196277, 45.9m, DateTime.Parse("1/05/2020 1:34")),
                new CustomerOrder(4442241, 2196275, 45.9m, DateTime.Parse("31/03/2021 1:51")),
                new CustomerOrder(4442241, 2196280, 6.96m, DateTime.Parse("31/03/2021 2:56")),
                new CustomerOrder(4442244, 2196276, 45.9m, DateTime.Parse("31/03/2021 1:54")),
                new CustomerOrder(4442247, 2196278, 45.9m, DateTime.Parse("31/03/2021 2:01")),
                new CustomerOrder(4442249, 2196283, 48.9m, DateTime.Parse("28/03/2021 4:20")),
                new CustomerOrder(4442249, 2196282, 28.95m, DateTime.Parse("30/03/2021 4:19")),
                new CustomerOrder(4442249, 2196281, 6.96m, DateTime.Parse("31/03/2021 4:17"))
            };
    }
}