using NUnit.Framework;
using Dima_demo_1_0_by14092022;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Test
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void ValidateSTR1VE_Email_TEST()
		{
			string mail = "This string is email addres";
			var exception = Assert.Throws<ValidationExceptions>(() => String_check.string_check_p4_str1("jdsfbks@mail.ru"));
			Assert.AreEqual(mail, exception.Message);
		}

		[Test]
		public void ValidateSTR1VE_Phone_TEST()
		{
			string mail = "This string is telephone number";
			var exception = Assert.Throws<ValidationExceptions>(() => String_check.string_check_p4_str1("+77777777777"));
			Assert.AreEqual(mail, exception.Message);
		}
		[Test]
		public void ValidateSTR1VE_IP_TEST()
		{
			string mail = "This string is IP addres";
			var exception = Assert.Throws<ValidationExceptions>(() => String_check.string_check_p4_str1("123.123.123.123"));
			Assert.AreEqual(mail, exception.Message);
		}
		[Test]
		public void ValidateSTR1VE_TEST()
		{
			var exception = Assert.Throws<ValidationExceptions>(() => String_check.string_check_p4_str1(string.Empty));
			Assert.AreEqual("строка не €вл€етс€ ничем, только кваказ€бры", exception.Message);
		}
		/*[Test]
		public void ValidateSTR1VE_IP_TEST()
		{
			string mail = "This string is IP addres";
			var exception = Assert.Throws<ValidationExceptions>(() => String_check.string_check_p4_str1("123.123.123.123"));
			Assert.AreEqual(mail, exception.Message);
		}*/
		//ƒЋя ¬“ќ–ќ… —“–ќ »
		[Test]
		public void ValidateSTR2VE_Email_TEST()
		{
			string mail = "This string is email addres";
			var exception = Assert.Throws<ValidationExceptions>(() => String_check.string_check_p4_str2("jdsfbks@mail.ru"));
			Assert.AreEqual(mail, exception.Message);
		}
		[Test]
		public void ValidateSTR2VE_Phone_TEST()
		{
			string mail = "This string is telephone number";
			var exception = Assert.Throws<ValidationExceptions>(() => String_check.string_check_p4_str2("+78888888888"));
			Assert.AreEqual(mail, exception.Message);
		}
		[Test]
		public void ValidateSTR2VE_IP_TEST()
		{
			string mail = "This string is IP addres";
			var exception = Assert.Throws<ValidationExceptions>(() => String_check.string_check_p4_str2("121.165.133.123"));
			Assert.AreEqual(mail, exception.Message);
		}
		[Test]
		public void ValidateSTR2VE_TEST()
		{
			var exception = Assert.Throws<ValidationExceptions>(() => String_check.string_check_p4_str2(string.Empty));
			Assert.AreEqual("строка не €вл€етс€ ничем, только кваказ€бры", exception.Message);
		}
		[Test]
		public void CheckValidateString_Not_TEST()
		{
			string str = "строки ne совпадают, с учЄтом их регистров";
			var exception = Assert.Throws<ValidationExceptions>(() => String_check.string_check_wRegister("123", "124"));
			Assert.AreEqual(str, exception.Message);
		}

		[Test]
		public void CheckValidateString_TEST()
		{
			var exception = Assert.Throws<ValidationExceptions>(() => String_check.string_check_wRegister(string.Empty, string.Empty));
			Assert.AreEqual("строки совпадают, с учЄтом их регистров", exception.Message);
		}
		[Test]
		public void CheckValidateStringNOTReg_TEST()
		{
			var exception = Assert.Throws<ValidationExceptions>(() => String_check.string_check_noRegister(string.Empty, string.Empty, string.Empty, string.Empty));
			Assert.AreEqual("строки совпадают, без учЄта их регистров", exception.Message);
		}
		[Test]
		public void CheckValidateStringNOTReg_Not_TEST()
		{
			string str = "строки ne совпадают, без учЄта их регистров";
			var exception = Assert.Throws<ValidationExceptions>(() => String_check.string_check_noRegister(" YeT", "YUI", "YET", "yui"));
			Assert.AreEqual(str, exception.Message);
		}
		[Test]
		public void CheckValidationStringReverse_TEST()
		{
			var exception = Assert.Throws<ValidationExceptions>(() => String_check.string_check_reverse(string.Empty, string.Empty, string.Empty, string.Empty));
			Assert.AreEqual("ќдна из строк €вл€етс€ перевЄртышем другой строки", exception.Message);
		}
		[Test]
		public void NOTMIN_TEST_ZERO_()
		{
			long result = 10;
			int expected = 0;
			var IOUtils = new IOUtils();
			int actual = IOUtils.check_fact(result);
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void NOTMIN_TEST2_ZERO_()
		{
			long result = 14; 
			int expected = 1;
			var IOUtils = new IOUtils();
			int actual = IOUtils.check_fact(result);
			Assert.AreEqual(expected, actual);
		}
	}
}