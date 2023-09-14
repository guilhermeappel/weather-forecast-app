import { CardContent, Typography } from '@mui/material';
import { IPeriod } from '../../types/weather-types';
import { StyledAvatar, StyledCard } from './styles';

interface IProps {
  data: IPeriod;
}

function WeatherCard({ data }: IProps) {
  const formattedDate = new Intl.DateTimeFormat('en-US', {
    month: 'short',
    day: 'numeric',
  }).format(new Date(data.startTime || ''));

  return (
    <StyledCard>
      <CardContent>
        <Typography variant="h5" fontWeight="bold">
          {data.name}
        </Typography>

        <Typography variant="subtitle1">{formattedDate}</Typography>

        <Typography variant="h6" sx={{ marginTop: 1 }}>
          {data.temperature}° {data.temperatureUnit}
        </Typography>

        <StyledAvatar sx={{ marginTop: 3 }} src={data.icon} alt="weather icon" />

        <Typography sx={{ marginTop: 3, fontWeight: 'medium' }}>
          Wind Speed: {data.windSpeed}
        </Typography>
        <Typography fontWeight="medium">Wind Direction: {data.windDirection}</Typography>
        <Typography fontWeight="medium">
          Precipitation: {data.probabilityOfPrecipitation?.value || 0}%
        </Typography>

        <Typography variant="body2" sx={{ marginTop: 3 }}>
          {data.shortForecast}
        </Typography>
      </CardContent>
    </StyledCard>
  );
}

export default WeatherCard;
