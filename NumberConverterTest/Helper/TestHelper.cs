using System;
using UnitConverter;

namespace UnitConverterTest
{
    public static class TestHelper
    {
        public static bool IsInvalidSubtraction(Action func)
        {
            try
            {
                func();
            }
            catch (InvalidSubtractionException ex)
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }

        public static bool IsParseException(Action func)
        {
            try
            {
                func();
            }
            catch (ParseException ex)
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }
        
    }
}
