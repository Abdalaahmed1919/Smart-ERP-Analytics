// ── INVENTORY page – Charts & UI ──

new Chart(document.getElementById('stockChart').getContext('2d'), {
  type: 'line',
  data: {
    labels: ['Aug','Sep','Oct','Nov','Dec','Jan'],
    datasets: [
      { label: 'Stock In', data: [450,480,460,610,590,670], borderColor: '#1db97a', borderWidth: 2.5, tension: 0.42, fill: false, pointRadius: 4, pointBackgroundColor: '#fff', pointBorderColor: '#1db97a', pointBorderWidth: 2 },
      { label: 'Stock Out', data: [390,420,420,520,510,600], borderColor: '#ef4444', borderWidth: 2.5, tension: 0.42, fill: false, pointRadius: 4, pointBackgroundColor: '#fff', pointBorderColor: '#ef4444', pointBorderWidth: 2 }
    ]
  },
  options: { plugins: { legend: { display: false }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } }, scales: { y: { grid: { color: '#f0f0f0' }, ticks: { font: { size: 11 }, color: '#9ca3af' } }, x: { grid: { display: false }, ticks: { font: { size: 11 }, color: '#9ca3af' } } } }
});
new Chart(document.getElementById('categoryChart').getContext('2d'), {
  type: 'bar',
  data: {
    labels: ['Electronics','Furniture','Accessories','Lighting','Office Supplies'],
    datasets: [{ data: [4500,3100,2800,1800,2200], backgroundColor: '#f97316', borderRadius: 5, borderSkipped: false, hoverBackgroundColor: '#ea6f10' }]
  },
  options: { plugins: { legend: { display: false }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } }, scales: { y: { grid: { color: '#f0f0f0' }, ticks: { font: { size: 11 }, color: '#9ca3af' } }, x: { grid: { display: false }, ticks: { font: { size: 11 }, color: '#9ca3af' } } } }
});