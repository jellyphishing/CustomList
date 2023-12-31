﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> :IEnumerable
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public int Count
        { 
            get 
            { 
                return count;
            }
          
        }

        public T this[int index] //dont worry about this yet...YET
        { 
            get 
            { 
                return items[index];
            }
            set 
            {
                items[index] = value;
            }
        }

        //Constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            if (count < capacity)
            {
                items[count] = item;
                count++;
            }
            else
            {
                capacity *= 2;
                T[] temporaryArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    temporaryArray[i] = items[i];
                }
                temporaryArray[count] = item;
                count++;
                items = temporaryArray; //throw out older smaller one, put bigger copy into items
                
            }
            
            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
        }

        public bool Remove(T item)
        {
            bool wasRemoved = false;
            if (count == 1 && items[0].Equals(item))
            {
                items[0] = default(T);
                wasRemoved = true;
            }
            else
            {
                T[] temporaryArray = new T[capacity];
                for (int i = 0, j = 0; i < count; i++, j++)
                {
                    //basically items[i] == item
                    if (items[i].Equals(item) && wasRemoved == false)
                    {
                        j--;
                        wasRemoved = true;
                    }
                    else
                    {
                        temporaryArray[j] = items[i];
                    }

                }
                items = temporaryArray;
            }
            if(wasRemoved == true)
            {
                count--;
            }
                /// //If 'item' exists in the 'items' array, remove its first instance
                //Any items coming after the removed item should be shifted down so there is no empty index.
                //If 'item' was removed, return true. If no item was removed, return false.
                return wasRemoved;
        }
        

        public override string ToString()
        {
            //items needs to get turned into a single string.  Use a for loop. use the += operator
            string finalString = "";
            
                for (int i = 0; i < count; i++)
                {
                    finalString += items[i].ToString();
                }
            //returns a single string that contains all items from array
            return finalString;
            
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
           CustomList<T> finalList = new CustomList<T>();

            for (int i = 0; i < firstList.Count; i++)
            {

              finalList.Add(firstList[i]);
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                finalList.Add(secondList[i]);
            }

            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return finalList;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> finalList = new CustomList<T>();
            for (int i = 0; i < firstList.Count; i++)
            {
                finalList.Add(firstList[i]);
            }
            for (int i = 0; i < secondList.Count; i++)
                {
                finalList.Remove(secondList [i]);
            }
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return finalList;
        }


    }
}
