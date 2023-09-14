import styled from '@mui/material/styles/styled';

export const WeatherForecastContainer = styled('div')({
  display: 'flex',
  flexDirection: 'column',
  alignItems: 'center',
  backgroundColor: '#1a1a1a',
});

export const WeatherCards = styled('div')({
  display: 'flex',
  gap: '2rem',
  width: '45%',
  overflowX: 'auto',
  padding: '0 20px 0 20px',
  '&::-webkit-scrollbar': {
    height: '5px',
  },
  '¨::-webkit-scrollbar-track': {
    backgroundColor: 'white',
  },
  '&::-webkit-scrollbar-thumb': {
    backgroundColor: 'white',
    borderRadius: 10,
  },
});

export const StyledInput = styled('input')({
  padding: '10px',
  borderRadius: '4px',
  border: '1px solid #666',
  marginRight: '10px',
  marginBottom: '20px',
  width: '250px',
  backgroundColor: '#2e2e2e',
  color: '#ccc',
});

export const StyledButton = styled('button')({
  padding: '10px 15px',
  borderRadius: '4px',
  background: '#555',
  color: '#ddd',
  cursor: 'pointer',
  border: 'none',
  transition: 'background-color 0.2s ease',
  '&:hover': {
    backgroundColor: '#444',
  },
});
