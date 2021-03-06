﻿using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MorseCodeDecoder.Tests
{
    [TestFixture]
    public class MorseCodeDecoderWithTestCaseSourceTests
    {
        [TestCase(".... . .-.. .-.. --- ....... .-- --- .-. .-.. -..", "HELLO WORLD")]
        [TestCase("..-. --- --- ....... -... .- .-.", "FOO BAR")]
        [TestCase("..- ... .. -. --. ....... - . ... - ....... -.-. .- ... .", "USING TEST CASE")]
        public void Decode_should_return_correct_text_with_test_case(string morseCode, string exepectedText)
        {
            //Arrange
            Decoder morseCodeDecoder = new Decoder();

            //Act
            var text = morseCodeDecoder.Decode(morseCode);

            //Assert
            Assert.That(text == exepectedText, () => "Morse code not decoded correctly");
        }

        static object[] MorseCodeCases =
        {
            new object[] { ".... . .-.. .-.. --- ....... .-- --- .-. .-.. -..", "HELLO WORLD" },
            new object[] { "..-. --- --- ....... -... .- .-.", "FOO BAR" },
            new object[] { "..- ... .. -. --. ....... - . ... - ....... -.-. .- ... .", "USING TEST CASE" }
        };

        [TestCaseSource(nameof(MorseCodeCases))]
        public void Decode_should_return_correct_text_with_test_case_source(string morseCode, string exepectedText)
        {
            //Arrange
            Decoder morseCodeDecoder = new Decoder();

            //Act
            var text = morseCodeDecoder.Decode(morseCode);

            //Assert
            Assert.That(text == exepectedText, () => "Morse code not decoded correctly");
        }

        [Test]
        public void Decode_should_throw_not_supported_exception_when_provided_text_is_null_or_empty()
        {
            //Arrange
            Decoder morseCodeDecoder = new Decoder();

            //Act &&  Assert
            Assert.Throws<NotSupportedException>(() => morseCodeDecoder.Decode(null));
        }
    }
}
