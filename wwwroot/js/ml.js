// ── ML page – Charts & UI ──

// ── Sales Revenue Forecast ──
const fCtx = document.getElementById('forecastChart').getContext('2d');
const predGrad = fCtx.createLinearGradient(0, 0, 0, 300);
predGrad.addColorStop(0, 'rgba(29,185,122,0.45)');
predGrad.addColorStop(1, 'rgba(29,185,122,0.02)');
new Chart(fCtx, {
  type: 'line',
  data: {
    labels: ['Feb','Mar','Apr','May','Jun','Jul'],
    datasets: [
      {
        label: 'Actual',
        data: [195000, null, null, null, null, null],
        borderColor: '#2563eb', borderWidth: 2.5,
        tension: 0.3, pointRadius: 5,
        pointBackgroundColor: '#2563eb', fill: false
      },
      {
        label: 'Predicted',
        data: [195000, 215000, 230000, 248000, 265000, 290000],
        fill: true, backgroundColor: predGrad,
        borderColor: '#1db97a', borderWidth: 2.5,
        borderDash: [6, 4], tension: 0.3,
        pointRadius: 4, pointBackgroundColor: '#1db97a'
      }
    ]
  },
  options: {
    plugins: { legend: { display: false }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } },
    scales: {
      y: { grid: { color: '#f0f0f0' }, ticks: { font: { size: 11 }, color: '#9ca3af', callback: v => v === 0 ? 0 : (v/1000)+'k' } },
      x: { grid: { display: false }, ticks: { font: { size: 11 }, color: '#9ca3af' } }
    }
  }
});

// ── Demand Forecasting ──
new Chart(document.getElementById('demandChart').getContext('2d'), {
  type: 'bar',
  data: {
    labels: ['Product A','Product B','Product C','Product D','Product E'],
    datasets: [
      { label: 'Current Demand',    data: [450,340,310,290,260], backgroundColor: '#9ca3af', borderRadius: 3, borderSkipped: false },
      { label: 'Forecasted Demand', data: [500,390,360,300,280], backgroundColor: '#1db97a', borderRadius: 3, borderSkipped: false }
    ]
  },
  options: {
    plugins: { legend: { display: false }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } },
    scales: {
      y: { grid: { color: '#f0f0f0' }, ticks: { font: { size: 11 }, color: '#9ca3af' } },
      x: { grid: { display: false }, ticks: { font: { size: 11 }, color: '#9ca3af' } }
    }
  }
});

// ── Customer Segmentation Scatter ──
new Chart(document.getElementById('scatterChart').getContext('2d'), {
  type: 'scatter',
  data: {
    datasets: [{
      data: [
        {x:15,y:25},{x:18,y:28},{x:22,y:45},
        {x:30,y:52},{x:32,y:90},{x:40,y:46},
        {x:43,y:88},{x:48,y:85},{x:52,y:78}
      ],
      backgroundColor: '#1db97a',
      pointRadius: 8,
      pointHoverRadius: 10
    }]
  },
  options: {
    maintainAspectRatio: false,
    plugins: { legend: { display: false }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } },
    scales: {
      y: { min: 0, max: 100, grid: { color: '#f0f0f0' }, ticks: { font: { size: 11 }, color: '#9ca3af' } },
      x: { min: 0, max: 60,  grid: { color: '#f0f0f0' }, ticks: { font: { size: 11 }, color: '#9ca3af' } }
    }
  }
});