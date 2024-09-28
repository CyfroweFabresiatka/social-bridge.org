import { createQuery } from '@/data/index'
import { useFetch } from '@/fetch'

export const useHomeQuery = () => {
  const fetch = useFetch();
  const { data, isLoading } = createQuery(
    ['home'],
    () => fetch.get<any>('/api/v1/projects')
  );
  
  return { data, isLoading };
}
