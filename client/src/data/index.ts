import { useQuery } from '@tanstack/vue-query'

export const createQuery = <T>(queryKey: any[], queryFn: () => Promise<T>, enabled: boolean = true) => {
  return useQuery({
    queryKey,
    queryFn,
    retry: 2,
    retryDelay: 1500,
    refetchOnWindowFocus: true,
    refetchOnMount: true,
    gcTime: 1000 * 60 * 5,
    staleTime: 1000 * 60 * 5,
    enabled,
  });
}
