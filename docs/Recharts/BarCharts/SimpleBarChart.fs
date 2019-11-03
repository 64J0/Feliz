[<RequireQualifiedAccess>]
module Samples.Recharts.BarCharts.SimpleBarChart

open Feliz
open Feliz.Recharts
open Fable.Core.Experimental

type Point = { name: string; uv: int; pv: int; }

let data = [
    { name = "Page A"; uv = 4000; pv = 2400 }
    { name = "Page B"; uv = 3000; pv = 1398 }
    { name = "Page C"; uv = 2000; pv = 9800 }
    { name = "Page D"; uv = 2780; pv = 3908 }
    { name = "Page E"; uv = 1890; pv = 4800 }
    { name = "Page F"; uv = 2390; pv = 3800 }
    { name = "Page G"; uv = 3490; pv = 4300 }
]

let chart = React.functionComponent(fun () -> [
    Recharts.barChart [
        barChart.width 500
        barChart.height 300
        barChart.data data
        barChart.children [
            Recharts.cartesianGrid [ cartesianGrid.strokeDasharray(3, 3) ]
            Recharts.xAxis [ xAxis.dataKey (fun p -> nameof p.name) ]
            Recharts.yAxis [ ]
            Recharts.tooltip [ ]
            Recharts.legend [ ]
            Recharts.bar [
                bar.dataKey (fun point -> nameof point.pv)
                bar.fill "#8884d8"
            ]

            Recharts.bar [
                bar.dataKey (fun point -> nameof point.uv)
                bar.fill "#82ca9d"
            ]
        ]
    ]
])