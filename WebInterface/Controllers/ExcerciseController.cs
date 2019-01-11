using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebInterface.Models;
using Excercise1;
using Excercise2;
using Excercise3;
using Excercise4;
using Excercise5;
using Excercise6;
using Excercise7;
using Excercise8;

namespace WebInterface.Controllers
{
    public class ExcerciseController : Controller
    {
        public IActionResult Excercise1()
        {
            var calc = new Calculator();
            ViewBag.Result = calc.ResolveProblem();
            return View();
        }

        public IActionResult Excercise2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Excercise2(int hour, int minutes)
        {
            var clock = new Clock();
            try
            {
                ViewBag.Result = clock.GetAngle(hour, minutes);
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
            }

            return View();
        }

        public IActionResult Excercise3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Excercise3(int number)
        {
            var numberTranslator = new NumberTranslator();
            try
            {
                ViewBag.Result = numberTranslator.FromDecimalToRoman(number);
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
            }

            return View();
        }
        public IActionResult Excercise4()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Excercise4(string wordOne, string wordTwo)
        {
            var anagram = new Anagram();
            try
            {
                ViewBag.Result = anagram.Verify(wordOne, wordTwo);
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
            }

            return View();
        }

        public IActionResult Excercise5()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Excercise5(string word)
        {
            var compresor = new Compresor();
            try
            {
                ViewBag.Result = compresor.Compress(word);
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
            }

            return View();
        }

        public IActionResult Excercise6()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Excercise6(string value)
        {
            var stringTransformer = new StringTransformer();
            try
            {
                ViewBag.Result = stringTransformer.Reverse(value);
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
            }

            return View();
        }

        public IActionResult Excercise7()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Excercise7(int year)
        {
            var calendar = new Calendar();
            try
            {
                ViewBag.Result = calendar.IsLeapYear(year);
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
            }

            return View();
        }

    }
}