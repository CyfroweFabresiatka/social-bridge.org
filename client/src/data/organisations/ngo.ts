import { createQuery } from '@/data/index'
import { useFetch } from '@/fetch'

export const useMyNgoQuery = () => {
  const fetch = useFetch()
  const { data, isLoading } = createQuery<Ngo>(['my-ngo'], () => fetch.get<Ngo>('/api/v1/ngos/my/'))

  return { data, isLoading }
}

export interface Ngo {
  name: string
  description: string
  location: string
  tags: string[]
}
