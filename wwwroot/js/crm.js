// ── CRM page – Charts & UI ──

// Customer Growth
new Chart(document.getElementById('growthChart').getContext('2d'), {
  type: 'line',
  data: {
    labels: ['Aug','Sep','Oct','Nov','Dec','Jan'],
    datasets: [{
      data: [440,458,465,472,480,542],
      borderColor: '#ec4899', borderWidth: 2.5,
      tension: 0.42, fill: false,
      pointRadius: 4, pointBackgroundColor: '#fff',
      pointBorderColor: '#ec4899', pointBorderWidth: 2,
      pointHoverRadius: 6
    }]
  },
  options: {
    plugins: { legend: { display: false }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } },
    scales: {
      y: { grid: { color: '#f0f0f0' }, ticks: { font: { size: 11 }, color: '#9ca3af' } },
      x: { grid: { display: false }, ticks: { font: { size: 11 }, color: '#9ca3af' } }
    }
  }
});

// Customer Segments
new Chart(document.getElementById('segmentChart').getContext('2d'), {
  type: 'pie',
  data: {
    labels: ['Enterprise: 35%', 'Mid-Market: 40%', 'Small Business: 25%'],
    datasets: [{
      data: [35, 40, 25],
      backgroundColor: ['#2563eb', '#1db97a', '#f97316'],
      borderWidth: 2, borderColor: '#fff'
    }]
  },
  options: {
    plugins: {
      legend: { position: 'right', labels: { font: { size: 11 }, padding: 14, boxWidth: 12 } },
      tooltip: { backgroundColor: '#1a1e2e', padding: 10 }
    }
  }
});

// Sales Pipeline
new Chart(document.getElementById('pipelineChart').getContext('2d'), {
  type: 'bar',
  data: {
    labels: ['Lead', 'Qualified', 'Proposal', 'Negotiation', 'Closed Won'],
    datasets: [{
      data: [45, 31, 29, 16, 13],
      backgroundColor: '#ec4899',
      borderRadius: 5, borderSkipped: false,
      hoverBackgroundColor: '#db2777'
    }]
  },
  options: {
    maintainAspectRatio: false,
    plugins: { legend: { display: false }, tooltip: { backgroundColor: '#1a1e2e', padding: 10 } },
    scales: {
      y: { grid: { color: '#f0f0f0' }, ticks: { font: { size: 11 }, color: '#9ca3af' } },
      x: { grid: { display: false }, ticks: { font: { size: 11 }, color: '#9ca3af' } }
    }
  }
});