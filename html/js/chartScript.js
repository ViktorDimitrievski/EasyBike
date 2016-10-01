// Chart Riste
   $(function () { window.onload = function() {
        var chart = new CanvasJS.Chart("chartContainer", {
            theme: "theme1",//theme1
            backgroundColor: "white",
            pointHitRadius: 50,
            title: {
                text: "Distance",
                fontColor: 'black',
                 pointRadius: 7,
            },

            animationEnabled: true,   // change to true

            data: [
                {
                    // Change type to "bar", "area", "spline", "pie",etc
                    type: "spline", lineTension: 0.1,
                    
                    dataPoints: [
                        { label: "Mon", y: 10 },
                        { label: "Tue", y: 25 },
                        { label: "Wen", y: 15 },
                        { label: "Thu", y: 30 },
                        { label: "Fre", y: 28 },
                        { label: "Sat", y: 37 },
                        { label: "Sun", y: 24 },
                        { label: "Mon", y: 16 },
                        { label: "Tue", y: 25 },
                        { label: "Wen", y: 36 },
                        { label: "Thu", y: 30 },
                        { label: "Fre", y: 18 }
                    ]
                }
            ]
        });
        chart.render();
    }
    });