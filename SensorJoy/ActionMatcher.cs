using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SensorJoy
{
    class ActionMatcher
    {
        //游戏模式
        public int mode = 1;
        
        //简单模式
        public const int MODE_EASY = 0;
        private const string GAS = "C";
        
        //复杂模式
        public const int MODE_HARD = 1;
        public const string GEAR_UP = "S";
        private const string GEAR_DOWN = "X";
        private const string BRAKE = "Q";
        private const int MAX_GEAR = 2;    //可调最大档位
        private const int MIN_GEAR = -1;    //倒车档
        public int gear = 0;    //档位
        public string GEARER = GEAR_UP;
        
        //方向键
        private const string LEFT = "LEFT";
        private const string RIGHT = "RIGHT";
        //油门
        private const string ACCELERATOR = "UP";
        //当前进行的操作
        private string action = "";
        private Boolean isDrifting = false;      //是否漂移的状态   
        //状态机中的状态变量
        private enum State { INITIAL, L1, L2, L3, L4, L5, L6, R1, R2, R3, R4, R5, R6};
        private State curState = State.INITIAL;
        private KeyHook keyhook;
        

        public ActionMatcher(KeyHook keyhook)
        {
            this.keyhook = keyhook;
        }

        public void match(byte data)
        {
            switch(data)
            {
                case 0:
                    if (curState == State.L3)
                    {
                        curState = State.L4;
                    }
                    else if (curState == State.R3)
                    {
                        curState = State.R4;
                    }
                    else if (curState != State.L4 && curState != State.R4 && !isDrifting)
                    {
                        keyhook.pressKey(ACCELERATOR);
                        curState = State.INITIAL;
                        if (!action.Equals(""))
                            keyhook.releaseKey(action);
                    }
                    break;
                case 3:                 
                    if(curState == State.INITIAL)
                    {
                        if(mode == MODE_EASY)
                        {
                            keyhook.pressKey(GAS);
                            action = GAS;
                        }
                        else
                        {
                            keyhook.pressKey(GEARER);
                            action = GEARER;
                            
                            if(GEARER == GEAR_DOWN)
                            {
                                gear--; 
                                if (gear == -1)
                                    GEARER = GEAR_UP;
                            }
                            else
                            {
                                gear++;
                                if (gear == MAX_GEAR)
                                    GEARER = GEAR_DOWN;
                            }
                            
                        }
                    }
                    break;
                case 4:
                    if(curState == State.INITIAL)
                    {
                        if(isDrifting)
                        {
                            Console.WriteLine("#############release brake");
                            keyhook.releaseKey(BRAKE);
                            isDrifting = false;
                        }
                        else
                        {
                            keyhook.pressKey(BRAKE);
                            isDrifting = true;
                        }
                    }
                    break;
                default:
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
                    break;

            }
            
        }
    }

}
