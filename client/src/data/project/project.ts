import { createQuery } from '@/data/index'
import { useFetch } from '@/fetch'
import { type CreateProjectReq, type Project } from '@/data/project/models'
import { useMutation, useQueryClient } from '@tanstack/vue-query'

export const useProjectQuery = (productSlug: string) => {
    const fetch = useFetch();
    const { data, isLoading, error } = createQuery<Project>(
        ['project', productSlug],
        () => fetch.get<Project>(`/api/v1/projects/${productSlug}`)
    );
    
    return { data, isLoading, error };
}

export function useProjectMutation() {
    const queryClient = useQueryClient()
    const onSuccess = () => queryClient.invalidateQueries({ queryKey: ['project'] })
    const fetch = useFetch();
    
    const addMutation = useMutation({
        mutationFn: (request: CreateProjectReq) => fetch.post<any>(`/api/v1/projects`, request),
        onSuccess: onSuccess
    })

    const editMutation = useMutation({
        mutationFn: (request: CreateProjectReq) => fetch.put<any>(`/api/v1/projects`, request),
        onSuccess: onSuccess
    })

    return {
        addMutationFn: addMutation.mutateAsync,
        editMutationFn: editMutation.mutateAsync
    }
}
