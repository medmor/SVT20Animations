using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DemographiqueEvolution : MonoBehaviour
{
    int[] years = new int[] { 1960,  1961,  1962,  1963,  1964,
   1965,  1966,  1967,  1968,
  1969,  1970,  1971,  1972,  1973,
   1974,  1975,  1976,  1977,
  1978,  1979,  1980,  1981,  1982,
   1983,  1984,  1985,  1986,
  1987,  1988,  1989,  1990,  1991,
   1992,  1993,  1994,  1995,
  1996,  1997,  1998,  1999,  2000,
   2001,  2002,  2003,  2004,
  2005,  2006,  2007,  2008,  2009,
   2010,  2011,  2012,  2013,
  2014,  2015,  2016,  2017,  2018,
   2019,  2020,  2021,  2022 };
    string[] population = new string[] {  "11 769 774",  "12 081 713",  "12 404 757",  "12 726 686",
  "13 044 254",  "13 381 880",  "13 738 502",  "14 109 755",  "14 490 077",
   "14 876 982",  "15 274 351",  "15 677 300",  "16 081 438",
  "16 489 452",  "16 902 383",  "17 325 325",  "17 756 516",  "18 206 472",
   "18 679 859",  "19 167 661", "19 678 444",  "20 208 260",
  "20 746 765",  "21 287 381", "21 817 271", "22 335 077", "22 824 446",
   "23 279 935",  "23 720 590",  "24 148 104",  "24 570 814",
  "24 988 083",  "25 400 676",  "25 806 777",  "26 201 551",  "26 599 048",
   "26 999 093",  "27 397 118",  "27 791 825",  "28 176 997",
  "28 554 415", "28 930 097", "29 301 817", "29 661 270", "30 033 125",
  "30 431 902", "30 833 022", "31 232 633", "31 634 992",
  "32 042 877", "32 464 865", "32 903 699", "33 352 169", "33 803 527",
  "34 248 603", "34 680 458", "35 107 264", "35 528 115",
  "35 927 511", "36 304 408", "36 688 772", "37 076 584", "37 457 971" };

    [SerializeField] private TextMeshPro yearsText;

    [SerializeField] private TextMeshPro populationText;

    [SerializeField] private float speed = 1;
    private float time = 0;
    private int i = 0;


    // Start is called before the first frame update
    void Start()
    {
        yearsText.text = years[i].ToString();
        populationText.text = population[i];
    }

    // Update is called once per frame
    void Update()
    {
        time += speed;
        if (time > 100 && i < years.Length)
        {
            yearsText.text = years[i].ToString();
            populationText.text = population[i];
            print("passed");
            time = 0;
            i++;
        }
    }
}

