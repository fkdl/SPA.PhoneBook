﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SPACore.PhoneBook.PhoneBooks.PhoneNumbers.Dtos;

namespace SPACore.PhoneBook.PhoneBooks.Persons.Dtos
{
    public class PersonEditDto
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        public int? Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(PhoneBookConsts.MaxNameLength)]
        public string Name { get; set; }
        [MaxLength(PhoneBookConsts.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }


        /// <summary>
        /// 地址信息
        /// </summary>
        [MaxLength(PhoneBookConsts.MaxAddressLength)]
        public string Address { get; set; }


        public List<PhoneNumberEditDto> PhoneNumbers { get; set; }


    }
}