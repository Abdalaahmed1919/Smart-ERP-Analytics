// ── PURCHASE page – Charts & UI ──

// Purchase Trend
new Chart(document.getElementById('purchaseTrend').getContext('2d'), {
  type: 'line',
  data: {
    labels: ['Aug','Sep','Oct','Nov','Dec','Jan'],
    datasets: [{
      data: [45000,52000,48000,61000,55000,68000],
      borderColor: '#2563eb', borderWidth: 2.5, tension: 0.42,
      fill: false, pointRadius: 4, pointBackgroundColor: '#fff',
      pointBorderColor: '#2563eb', pointBorderWidth: 2, pointHoverRadius: 6
    }]
  },
  options: {
    plugins: { legend: { display: false }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } },
    scales: {
      y: { grid: { color: '#f0f0f0' }, ticks: { font: { size: 11 }, color: '#9ca3af', callback: v => v===0?0:(v/1000)+'k' } },
      x: { grid: { display: false }, ticks: { font: { size: 11 }, color: '#9ca3af' } }
    }
  }
});
// Suppliers
new Chart(document.getElementById('suppliersChart').getContext('2d'), {
  type: 'bar',
  data: {
    labels: ['Tech Supplies','Office Solutions','Industrial Parts','Global Traders','Quality Materials'],
    datasets: [{ data: [24,18,14,12,10], backgroundColor: '#2563eb', borderRadius: 4, borderSkipped: false, hoverBackgroundColor: '#1d4ed8' }]
  },
  options: {
    indexAxis: 'y',
    plugins: { legend: { display: false }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } },
    scales: {
      x: { grid: { color: '#f0f0f0' }, ticks: { font: { size: 11 }, color: '#9ca3af' } },
      y: { grid: { display: false }, ticks: { font: { size: 11 }, color: '#9ca3af' } }
    }
  }
});