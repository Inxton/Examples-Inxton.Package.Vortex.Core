namespace PLC 
            {
            using System;
                internal class PLCTwinController
                {
                    internal static TranslatorPLCTwinController Translator = new TranslatorPLCTwinController();
                }

                internal class TranslatorPLCTwinController
                {
                    public string Translate(string str)
                    {
                        return str;
                    }
                }
            }