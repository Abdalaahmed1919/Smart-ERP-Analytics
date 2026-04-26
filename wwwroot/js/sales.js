// ── SALES page – Charts & UI ──

//const greenGrad = ctx => { const g = ctx.createLinearGradient(0,0,0,260); g.addColorStop(0,'rgba(29,185,122,0.45)'); g.addColorStop(1,'rgba(29,185,122,0.02)'); return g; };
//new Chart(document.getElementById('revenueChart').getContext('2d'), {
//  type: 'line',
//  data: {
//    labels: ['Aug','Sep','Oct','Nov','Dec','Jan'],
//    datasets: [{ data: [130000,145000,148000,165000,160000,18500], fill: true, backgroundColor: ctx => greenGrad(ctx.chart.ctx), borderColor: '#1db97a', borderWidth: 2.5, tension: 0.42, pointRadius: 4, pointBackgroundColor: '#fff', pointBorderColor: '#1db97a', pointBorderWidth: 2, pointHoverRadius: 6 }]
//  },
//  options: { plugins: { legend: { display: false }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } }, scales: { y: { grid: { color: '#f0f0f0' }, ticks: { font: { size: 11 }, color: '#9ca3af', callback: v => v===0?0:(v/1000)+'k' } }, x: { grid: { display: false }, ticks: { font: { size: 11 }, color: '#9ca3af' } } } }
//});
//new Chart(document.getElementById('productChart').getContext('2d'), {
//  type: 'bar',
//  data: { labels: ['Product A','Product B','Product C','Product D','Product E'], datasets: [{ data: [46000,37000,31000,27000,21000], backgroundColor: '#1db97a', borderRadius: 5, borderSkipped: false, hoverBackgroundColor: '#15a066' }] },
//  options: { plugins: { legend: { display: false }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } }, scales: { y: { grid: { color: '#f0f0f0' }, ticks: { font: { size: 11 }, color: '#9ca3af', callback: v => v===0?0:(v/1000)+'k' } }, x: { grid: { display: false }, ticks: { font: { size: 11 }, color: '#9ca3af' } } } }
//});