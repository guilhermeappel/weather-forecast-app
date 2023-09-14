import { Avatar, Card, Typography } from '@mui/material';
import styled from '@mui/material/styles/styled';

export const StyledCard = styled(Card)(({ theme }) => ({
  flex: '0 0 auto',
  width: '250px',
  maxHeight: '420px',
  margin: theme.spacing(4, 0),
  boxShadow: theme.shadows[5],
  borderRadius: '10px',
  backgroundColor: '#2e2e2e',
  color: '#ddd',
  transition: 'transform 0.2s ease',
  '&:hover': {
    transform: 'scale(1.05)',
  },
}));

export const StyledAvatar = styled(Avatar)(({ theme }) => ({
  width: '80px',
  height: '80px',
  margin: theme.spacing(2, 'auto'),
  background: 'transparent',
  color: '#ddd',
}));

export const HighlightText = styled(Typography)({
  fontWeight: 'bold',
});
