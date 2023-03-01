using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_Demos
{
    public class RombusAsStringDrawer
    {
        public string Draw(int countOfStars)
        {
            StringBuilder sb = new StringBuilder();

            DrawTopPart(sb, countOfStars);           
            DrawDownPart(sb, countOfStars);

            return sb.ToString().TrimEnd();

        }
        private void DrawTopPart(StringBuilder sb, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                sb.Append(new string(' ', n - i));
                DrawLineOfStars(sb, i);

            }
        }

        private void DrawDownPart(StringBuilder sb, int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                sb.Append(new string(' ', n - i));
                DrawLineOfStars(sb, i);
            }
        }
        private void DrawLineOfStars(StringBuilder sb, int numberOfStars)
        {

            for (int j = 0; j < numberOfStars; j++)
            {
                sb.Append('*');

                if (j < numberOfStars - 1)
                {
                    sb.Append(' ');
                }

            }

            sb.AppendLine();
        }
    }
}
