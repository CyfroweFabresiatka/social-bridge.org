import { createQuery } from '@/data/index'
import { useFetch } from '@/fetch'
import { type Project } from '@/data/project/models'
import { useMutation, useQuery, useQueryClient } from '@tanstack/vue-query'

export const useProjectQuery = (productSlug: string) => {
    const fetch = useFetch();
    const { data, isLoading, error } = createQuery<Project>(
        ['project', productSlug],
        () => fetch.get<Project>(`/api/v1/projects/${productSlug}`)
    );
    
    return { data, isLoading, error };
}

export function useProjectMutation(request: CreateProject) {
    const queryClient = useQueryClient()
    const onSuccess = () => queryClient.invalidateQueries({ queryKey: ['project'] })
    const fetch = useFetch();
    
    const addMutation = useMutation({
        mutationFn: (request: CreateProject) => fetch.post<CreateProject>(`/api/v1/projects`, request),
        onSuccess: onSuccess
    })

    const editMutation = useMutation({
        mutationFn: (request: CreateProject) => fetch.put<CreateProject>(`/api/v1/projects`, request),
        onSuccess: onSuccess
    })

    return {
        addMutationFn: addMutation.mutateAsync,
        editMutationFn: editMutation.mutateAsync
    }
}