﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorJoy
{
    class ActionMatcher
    {
        private static string LEFT = "LEFT";
        private static string RIGHT = "RIGHT";
        private static string UP = "UP";

        private enum State { INITIAL, L1, L2, L3, L4, L5, L6, R1, R2, R3, R4, R5, R6};
        private State curState = State.INITIAL;
        private KeyHook keyhook;
        private string action = "";

        public ActionMatcher(KeyHook keyhook)
        {
            this.keyhook = keyhook;
        }

        public void match(byte data)
        {
            if(data == 0)
            {
                if(curState == State.L3)
                {
                    curState = State.L4;
                }
                else if(curState == State.R3)
                {
                    curState = State.R4;
                }
                else if(curState != State.L4 && curState != State.R4)
                {
                    keyhook.pressKey(UP);
                    curState = State.INITIAL;
                }
            }
            else
            {
                switch (curState)
                {
                    case State.INITIAL:
                        if (data == 1)
                        {
                            curState = State.L1;
                        }
                        else
                        {
                            curState = State.R1;
                        }
                        break;
                    case State.L1:
                        if (data == 1)
                        {
                            curState = State.L2;
                        }
                        else
                        {
                            curState = State.INITIAL;
                        }
                        break;
                    case State.L2:
                        if (data == 1)
                        {
                            curState = State.L3;
                            keyhook.pressKey(LEFT);
                            action = LEFT;
                        }
                        else
                        {
                            curState = State.INITIAL;
                        }
                        break;
                    case State.L3:
                        if (data == 2)
                        {
                            curState = State.L5;
                            if (action.Equals(LEFT))
                            {
                                keyhook.releaseKey(LEFT);
                                action = "";
                            }
                        }
                        else
                        {
                            curState = State.L4;
                        }
                        break;
                    case State.L4:
                        if (data == 2)
                        {
                            curState = State.L5;
                            if (action.Equals(LEFT))
                            {
                                keyhook.releaseKey(LEFT);
                                action = "";
                            }
                        }
                        break;
                    case State.L5:
                        if (data == 1)
                        {
                            curState = State.L1;
                        }
                        else
                        {
                            curState = State.L6;
                        }
                        break;
                    case State.L6:
                        if(data == 1)
                        {
                            curState = State.L1;
                        }
                        else
                        {
                            curState = State.INITIAL;
                        }
                        break;
                    case State.R1:
                        if (data == 2)
                        {
                            curState = State.R2;
                        }
                        else
                        {
                            curState = State.INITIAL;
                        }
                        break;
                    case State.R2:
                        if(data == 2)
                        {
                            curState = State.R3;
                            keyhook.pressKey(RIGHT);
                            action = RIGHT;
                        }
                        else
                        {
                            curState = State.INITIAL;
                        }
                        break;
                    case State.R3:
                        if (data == 1)
                        {
                            curState = State.R5;
                            if (action.Equals(RIGHT))
                            {
                                keyhook.releaseKey(RIGHT);
                                action = "";
                            }
                        }
                        else
                        {
                            curState = State.R4;
                        }
                        break;
                    case State.R4:
                        if (data == 1)
                        {
                            curState = State.R5;
                            if (action.Equals(RIGHT))
                            {
                                keyhook.releaseKey(RIGHT);
                                action = "";
                            }
                        }
                        break;
                    case State.R5:
                        if (data == 2)
                        {
                            curState = State.R1;
                        }
                        else
                        {
                            curState = State.R6;
                        }
                        break;
                    case State.R6:
                        if(data == 2)
                        {
                            curState = State.R1;
                        }
                        else
                        {
                            curState = State.INITIAL;
                        }
                        break;
                    default:
                        break;
                }
            }
            
        }
    }

    /**
     * 
    public static int STATE_BEGIN = -1;
        public static int STATE_MATCH = 3;

        //定义两个用于匹配的状态机
        private byte[,] states = new byte[,]{{1, 1, 2, 2}, {2, 2, 1, 1}};
        private int state = STATE_BEGIN;
        private int type = 0;
        
        public int match(byte data)
        {
            if (data == 0)
                return -1;
            if(state == STATE_BEGIN || states[type, state + 1] != data)
            {
                state = 0;
                if(data == 1)
                {
                    type = 0;
                }
                else
                {
                    type = 1;
                }
            }
            else
            {
                state++;
                if(state == STATE_MATCH)
                {
                    state = STATE_BEGIN;
                    return type;
                }
            }
            return -1;
        }
    **/
}
