using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PomodoroTimer
{
    class ColorTransition
    {
        private int transitionSteps = 10;
        private int transitionStep = 0;

        private int RedR = 249;
        private int RedG = 61;
        private int RedB = 51;

        private int GreenR = 34;
        private int GreenG = 139;
        private int GreenB = 34;

        private int CurrentR = 0;
        private int CurrentG = 0;
        private int CurrentB = 0;

        public ColorTransition(bool _isRed)
        {
            setDefaultCurrent(_isRed);
        }

        public bool isRed { get; private set; } = false;
        public bool isGreen { get; private set; } = false;

        private void setDefaultCurrent(bool _isRed)
        {
            if (_isRed)
            {
                CurrentR = RedR;
                CurrentG = RedG;
                CurrentB = RedB;
                isRed = true;
            }
            else
            {
                CurrentR = GreenR;
                CurrentG = GreenG;
                CurrentB = GreenB;
                isGreen = true;
            }
        }

        public Color getRedColor()
        {
            if (isGreen)
            {
                setDefaultCurrent(false);
                isGreen = false;
            }
            if (!isRed)
            {
                transitionToRed();
            }
            return getCurrentColor();
        }

        public Color getGreenColor()
        {
            if (isRed)
            {
                setDefaultCurrent(true);
                isRed = false;
            }
            if (!isGreen)
            {
                isRed = false;
                transitionToGreen();
            }
            return getCurrentColor();
        }

        private Color getCurrentColor()
        {
            return Color.FromArgb(CurrentR, CurrentG, CurrentB);
        }

        private void transitionToRed()
        {
            if (transitionStep == transitionSteps)
            {
                isRed = true;
                transitionStep = 0;
                CurrentR = RedR;
                CurrentG = RedG;
                CurrentB = RedB;
            }
            else
            {
                int redStep = (RedR - GreenR) / transitionSteps;
                int greenStep = (RedG - GreenG) / transitionSteps;
                int blueStep = (RedB - GreenB) / transitionSteps;

                CurrentR += redStep;
                CurrentG += greenStep;
                CurrentB += blueStep;

                transitionStep++;
            }
        }

        private void transitionToGreen()
        {
            if (transitionStep == transitionSteps)
            {
                isGreen = true;
                transitionStep = 0;
                CurrentR = GreenR;
                CurrentG = GreenG;
                CurrentB = GreenB;
            }
            else
            {
                int redStep = (GreenR - RedR) / transitionSteps;
                int greenStep = (GreenG - RedG) / transitionSteps;
                int blueStep = (GreenB - RedB) / transitionSteps;

                CurrentR += redStep;
                CurrentG += greenStep;
                CurrentB += blueStep;

                transitionStep++;
            }

        }
    }
}
