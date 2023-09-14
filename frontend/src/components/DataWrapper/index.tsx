interface IProps {
  loading: boolean;
  error: Error | null;
  children: React.ReactNode;
}

function DataWrapper({ loading, error, children }: IProps) {
  if (loading) {
    return <div>Loading...</div>;
  }

  if (error) {
    return <div>Error: {error.message}</div>;
  }

  return <>{children}</>;
}

export default DataWrapper;
